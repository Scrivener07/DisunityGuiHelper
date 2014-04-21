using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


namespace DisunityGuiHelper
{
	class ATA4
	{
		public string[] CommandList = new string[] 
        {
/*0*/		" Help ",
/*1*/		" list ",
/*2*/		" info ",
/*3*/		" info-stats ",
/*4*/		" dump ", 
/*5*/		" dump-struct ", 
/*6*/		" extract ",
/*7*/		" extract-raw ",
/*8*/		" fixrefs ",
/*9*/		" split ",
/*10*/		" bundle-list ",
/*11*/		" bundle-extract ",
/*12*/		" learn " 
		};
		


		public string[] CommandHintList = new string[] 
        {
/*0*/		"Help, the same as using the -h switch for further usage information.",
/*1*/		"Lists all asset objects in a tabular form.",
/*2*/		"Outputs various information for asset and asset bundle files.",
/*3*/		"Outputs class usage statistics for asset files.",
/*4*/		"Converts binary object data to human-readable plain text, similar to the binary2text tool shipped with the Unity editor.",
/*5*/		"Like dump, but just for the structure information.",
/*6*/		"Extracts asset objects to regular files (.txt, .wav, .tga, etc.)",
/*7*/		"Extracts raw serialized object data. Could be useful for manual extraction if extract doesn't support the wanted asset type.",
/*8*/		"Fixes shared asset references in extracted scene files by converting relative to absolute paths so they can be opened with the Unity editor correctly. Note: If the shared assets are moved to a different folder, the scene needs to be fixed again.",
/*9*/		"Attempts to split an asset file into multiple smaller asset files.",
/*10*/		"Lists all files contained in Unity webplayer bundles (*.unity3d).",
/*11*/		"Extracts all packed files from Unity webplayer bundles (*.unity3d).",
/*12*/		"Learns the structure information from the submitted files and stores any new structs in the database file structdb.dat. The database is required to deserialize standalone asset files, which usually don't contain any structure information." 
        };


		public const int IDHelp = 0;
		public const int IDList = 1;
		public const int IDInfo = 2;
		public const int IDInfoStats = 3;
		public const int IDDump = 4;
		public const int IDDumpStruct = 5;
		public const int IDExtract = 6;
		public const int IDExtractRaw = 7;
		public const int IDFixRefs = 8;
		public const int IDSplit = 9;
		public const int IDBundleList = 10;
		public const int IDBundleExtract = 11;
		public const int IDLearn = 12;
		public static string ClassFilterMessage = "\n\nUse the class filter to only process objects of the specified class.\nThe filter expects a string with class names, separated by commas. \nSee SUPPORT.md for a list of supported asset types.".Replace("\n", Environment.NewLine);
	
		
		private string DisunityCommand;



		/// <summary>
		/// Object for interacting with ata4's disunity cli.
		/// </summary>
		public ATA4()
		{
			DisunityCommand = " -jar \"" + Program.DisunityPath + "\"";
		}



		public static string ShowHintMessage(int msg = 0)
		{
			if (msg == 0)
			{
				string s =
					"Type: AudioClip, Status: Ok" +
					"\nType: Font, Status: Ok, but wrong file extension for OpenType fonts" +
					"\nType: Mesh, Status: Unity 4 and uncompressed only" +
					"\nType: TextAsset, Status: Ok" +
					"\nType: Shader, Status: Ok" +
					"\nType: Texture2D, Status: Missing support for PVR, ATC and some exotic color formats" +
					"\nType: Cubemap, Status: Wrong texture flags" +
					"\nType: SubstanceArchive, Status: Ok" +
					"\nType: MovieTexture, Status: Ok";
				return s;
			}
			else
			{
				return "Sorry, no message at that index.";
			}
		}



		/// <summary>
		/// Sends user provided command and target to disunity.
		/// </summary>
		/// <param name="cmd">The command to execute.</param>
		/// <param name="target">The file or directory to process.</param>
		/// <returns>Disunitys standard output.</returns>
		public string RequestCommand(string cmd, string target = null)
		{
			if (!String.IsNullOrEmpty(target))
			{
				target = " \"" + target + "\"";
			}
			if (!String.IsNullOrEmpty(cmd))
			{
				cmd = " " + cmd;
			}
			return SendCommand(cmd + target);
		}




		/// <summary>
		/// Send command preset with parameters.
		/// </summary>
		/// <param name="verbose">Shows more verbose log output.</param>
		/// <param name="cmd">The processing command to use.</param>
		/// <param name="target">The file or directory to process.</param>
		/// <param name="filter">Only process objects that use these classes.</param>
		/// <returns>Disunitys standard output.</returns>
		public string RequestPreset(bool verbose = true, int cmd = 0, string target = null, string filter = null)
		{
			if (cmd == 0)
			{
				return AskHelp();
			}
			string f = "";
			if (!String.IsNullOrEmpty(filter))
			{
				f = " -f " + filter + " ";
			}
			string v = "";
			if (verbose)
			{
				v = " -v ";
			}
			return SendCommand(CommandList[cmd] + f + v  + " \"" + target + "\"");
		}




		/// <summary>
		/// Execute disunity with -h switch for basic usage information.
		/// </summary>
		/// <returns>Disunitys standard output.</returns>
		public string AskHelp()
		{
			return SendCommand(" -h");
		}




		/// <summary>
		/// Starts a new disunity process using the provided arguments.
		/// </summary>
		/// <param name="a_args"></param>
		/// <returns>Disunitys standard output.</returns>
		private string SendCommand(string a_args)
		{
			ProcessStartInfo startinfo = new ProcessStartInfo();
			startinfo.FileName = Program.JavaPath;
			startinfo.Arguments = DisunityCommand + a_args;
			startinfo.UseShellExecute = false;
			startinfo.CreateNoWindow = true;
			startinfo.RedirectStandardInput = true;
			startinfo.RedirectStandardOutput = true;
			Console.WriteLine(">Executing.. " + Program.JavaPath + " " + DisunityCommand + " " + a_args + "\nBusy, this may take a minute or two.");
			Process javaProc = new Process();
			javaProc.StartInfo = startinfo;
			javaProc.Start();
			string output = javaProc.StandardOutput.ReadToEnd();
			javaProc.WaitForExit();
		//	System.Threading.Thread.Sleep(1000);
			Console.WriteLine("Done executing.\n");
			return output;
		}

	}
}
