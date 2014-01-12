using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace Barracuda
{
    class ATA4
    {
        public const int IDHelp         = 0;
        public const int IDList         = 1;
        public const int IDInfo         = 2;
        public const int IDInfoStats    = 3;
        public const int IDDump         = 4;
        public const int IDDumpStruct   = 5;
        public const int IDExtract      = 6;
        public const int IDExtractRaw   = 7;
        public const int IDFixRefs      = 8;
        public const int IDSplit        = 9;
        public const int IDUnbundle     = 10;
        public const int IDLearn        = 11;


        public static string RequestCommand(string a_target, int a_cmd)
        {
            string Disunity = Barracuda.Program.DisunityPath;
            string[] CommandList = new string[] 
                {
                    " -h ",
                    " -c list ",
                    " -c info ",
                    " -c info-stats ",
                    " -c dump ",
                    " -c dump-struct ",
                    " -c extract ",
                    " -c extract-raw ",
                    " -c fixrefs ",
                    " -c split ",
                    " -c unbundle ",
                    " -c learn " 
                };

            if(a_target == null || a_target == "")
            {
                string ARGS = Disunity + CommandList[IDHelp];
                return SendCommand(ARGS);
            } else {
                string ARGS = Disunity + CommandList[a_cmd] + "\"" + a_target + "\"";
                return SendCommand(ARGS);
            }
        }


        private static string SendCommand(string a_args)
        {
            string myJava = Barracuda.Program.JavaPath;
            Console.WriteLine("Executing..\n Java= " + myJava + "\n Arguments=" + a_args);
            ProcessStartInfo startinfo = new ProcessStartInfo();
                startinfo.FileName = myJava;
                startinfo.Arguments = a_args;
                startinfo.UseShellExecute = false;
                startinfo.CreateNoWindow = true;
                startinfo.RedirectStandardInput = true;
                startinfo.RedirectStandardOutput = true;
            Process javaProc = new Process();
                javaProc.StartInfo = startinfo;
                javaProc.Start();
                string output = javaProc.StandardOutput.ReadToEnd();
                javaProc.WaitForExit();
            Console.WriteLine("Done executing.\n");
            return output;
        }




    }
}
