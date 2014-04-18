using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;


namespace DisunityGuiHelper
{
    internal sealed class Program
    {

        public static string JavaPath
        {
            get { return user_javapath; }
            set { user_javapath = value; }
        }
        private static string user_javapath;


        public static string ProgramPath
        {
            get { return user_ProgramPath; }
            set { user_ProgramPath = value; }
        }
        private static string user_ProgramPath;


        public static string DisunityPath
        {
            get { return user_DisunityPath; }
            set { user_DisunityPath = value; }
        }
        private static string user_DisunityPath;


		private const string disunityAssemblyName = "disunity.jar";
		private const string disunityPrompt = "Could not find " + disunityAssemblyName + " in startup directory.\nPress OK to browse for disunity or Cancel to exit the application.";

		private const string javaPrompt = "No standard Java installation found.\nPress OK to browse for java.exe or Cancel to exit the application.";



        [STAThread]
        static void Main()
        {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Startup();
            Application.Run(new ToolWindow()); 
        }


		private static void Startup()
		{
			user_ProgramPath = Application.StartupPath;
			Console.WriteLine("Startup Path [" + user_ProgramPath + "]\n");

			user_DisunityPath = LocateDisunity();
			Console.WriteLine("Disunity [" + user_DisunityPath + "]\n");

			user_javapath = LocateJava();
			Console.WriteLine("Java [" + user_javapath + "]\n");
		}




		private static string LocateDisunity()
		{
			Console.WriteLine("Looking for Disunity.");

			if (File.Exists(disunityAssemblyName))
			{
				Console.WriteLine("Found Disunity in the application startup directory.");
				return disunityAssemblyName;
			}
			else
			{
				DialogResult result = MessageBox.Show(disunityPrompt, "Could not find " + disunityAssemblyName, MessageBoxButtons.OKCancel);
				if (result == DialogResult.OK)
				{
					string custompath = FindAssemblyDialog("Disunity Assembly | *.jar");
					if (!File.Exists(custompath))
					{
						Environment.Exit(0);
					}
					else
					{
						Console.WriteLine("Non-standard Disunity path has been selected.");
						return custompath;
					}
				}
				else if (result == DialogResult.Cancel)
				{
					Console.WriteLine("Please close this dialog and exit the application.");
					Environment.Exit(0);
				}
				return "";
			}
		}





        private static string LocateJava()
        {
			Console.WriteLine("Looking for Java.");
            const string java64 = @"C:\Program Files\Java\jre7\bin\java.exe"; 
            const string java32 = @"C:\Program Files (x86)\Java\jre7\bin\java.exe";

            if (File.Exists(java64))
            {
                Console.WriteLine("-Standard 64bit JRE installation exists.");
                return java64;
            } else if (File.Exists(java32)) {
                Console.WriteLine("-Standard 32bit JRE installation exists. Avoid processing larger files because of limited heap size.");
                return java32;
            } 
			else 
			{ 
				DialogResult result = MessageBox.Show(javaPrompt, "Could not find java.exe", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
					string custompath = FindAssemblyDialog("Java Assembly |java.exe");
					if (!File.Exists(custompath))
					{
						Environment.Exit(0);
					}
					else
					{
						Console.WriteLine("Non-standard Java path has been selected.");
						return custompath;
					}
                }
                else if (result == DialogResult.Cancel)
                {
					Console.WriteLine("Please close this dialog and exit the application.");
					Environment.Exit(0);
                }
				return "";
            }
        }




		private static string FindAssemblyDialog(string filter)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.InitialDirectory = ProgramPath;
			dialog.Filter = filter;
			dialog.RestoreDirectory = true;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				return dialog.FileName;
			}
			else
			{
				return "";
			}
		}




    }
}

