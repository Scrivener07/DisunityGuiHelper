using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

namespace Barracuda
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



        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Console.WriteLine("Setting application startup path.");
            user_ProgramPath = Application.StartupPath;
            Console.WriteLine("Path [" + user_ProgramPath + "]\n");

            Console.WriteLine("Setting disunity command path");
            user_DisunityPath = " -jar \"" + user_ProgramPath + "\\disunity.jar\"";
            Console.WriteLine("Path [" + user_DisunityPath + "]\n\n");

            Console.WriteLine("Looking for Java.");
            user_javapath = LocateJava();
            Console.WriteLine("Found Java [" + user_javapath + "]\n");

            Application.Run(new ToolWindow()); 
        }











        private static string LocateJava()
        {
            const string java64 = @"C:\Program Files\Java\jre7\bin\java.exe"; 
            const string java32 = @"C:\Program Files (x86)\Java\jre7\bin\java.exe";

            if (File.Exists(java64))
            {
                Console.WriteLine("-Standard 64bit JRE installation exists.");
                return java64;
            } else if (File.Exists(java32)) {
                Console.WriteLine("-Standard 32bit JRE installation exists. Avoid processing larger files because of limited heap size.");
                return java32;
            } else { //prompt user
                DialogResult result = MessageBox.Show(
                    "No standard Java installation found.\nPress OK to browse for java.exe or Cancel to exit the application.", 
                    "Could not find java.exe", 
                    MessageBoxButtons.OKCancel
                    );
                if (result == DialogResult.OK)
                {
                    OpenFileDialog JavaDialog = new OpenFileDialog();
                    JavaDialog.InitialDirectory = "c:\\";
                    JavaDialog.Filter = "Java Runtime |java.exe";
                    JavaDialog.RestoreDirectory = true;

                    if (JavaDialog.ShowDialog() == DialogResult.OK)
                    {
                        return JavaDialog.FileName;
                    }
                    else if (JavaDialog.ShowDialog() == DialogResult.Cancel)
                    {
                        Environment.Exit(0);
                    }  
                }
                else if (result == DialogResult.Cancel)
                {
                    Environment.Exit(0);
                }
            }
            return null;
        }


    }
}

