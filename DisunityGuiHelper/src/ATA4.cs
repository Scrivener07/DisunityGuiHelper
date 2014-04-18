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
/*0*/		" -h",
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
/*6*/		"Extracts asset objects to regular files (.txt, .wav, .tga, etc.)" + ClassFilterMessage,
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

		private string DisunityCommand;
		private static string ClassFilterMessage = "\n\nUse the class filter to only process objects of the specified class. The filter expects a string with class names, separated by commas. See SUPPORT.md for a list of supported asset types.".Replace("\n", Environment.NewLine);


		public ATA4()
		{
			DisunityCommand = " -jar \"" + Program.DisunityPath + "\"";
		}



		public string RequestCommand(string a_target, int a_cmd, string a_filter = null)
		{
			string r;
			if (a_target == null || a_target == "")
			{
				r = SendCommand(DisunityCommand + CommandList[IDHelp]);
			}
			else if (a_filter == null || a_filter == "")
			{
				r = SendCommand(DisunityCommand + CommandList[a_cmd] + "\"" + a_target + "\"");
			}
			else if (a_filter != null || a_filter != "")
			{
				r = SendCommand(DisunityCommand + " -f " + a_filter + " \"" + a_target + "\"");
			}
			else
			{
				r = "Aborted!\n";
			}
			return r;
		}



		private string SendCommand(string a_args)
		{
			ProcessStartInfo startinfo = new ProcessStartInfo();
			startinfo.FileName = Program.JavaPath;
			startinfo.Arguments = a_args;
			startinfo.UseShellExecute = false;
			startinfo.CreateNoWindow = true;
			startinfo.RedirectStandardInput = true;
			startinfo.RedirectStandardOutput = true;
			Console.WriteLine("> Executing.. " + Program.JavaPath + " " + a_args + "\n Busy, this may take a minute or two.");
			Process javaProc = new Process();
			javaProc.StartInfo = startinfo;
			javaProc.Start();
			string output = javaProc.StandardOutput.ReadToEnd();
			javaProc.WaitForExit();
			//System.Threading.Thread.Sleep(5000);
			Console.WriteLine("Done executing.\n");
			return output;
		}


	}
}
