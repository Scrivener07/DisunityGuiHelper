using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace Barracuda
{
    public partial class ToolWindow : Form
    {

        private string ExecuteTarget = null;
        private int ExecuteCommand = 0;


        public ToolWindow()
        {
            InitializeComponent();
            this.CommandParamCombo.SelectedIndex = 0;
            this.FindFilePathTextBox.Text = "There is no target selected";
            UpdateCommandHint();
        }



        private void FindFileButton_OnClick(object sender, EventArgs e)
        {
            string userTarget = this.ShowFileBrowser(typefilter_UNITY);
            if (File.Exists(userTarget))
            {
                ExecuteTarget = this.BrowseFileDialog.FileName;
                WriteOutput("Pending File: " + ExecuteTarget);
                this.FindFilePathTextBox.Text = ExecuteTarget;
            }
            else
            {
                WriteOutput("File does not exist.");
            }
        }




        private void CommandParamCombo_OnSelectionChangeCommitted(object sender, EventArgs e)
        {
            ExecuteCommand = this.CommandParamCombo.SelectedIndex;
            WriteOutput("Pending Command: " + ExecuteCommand);
            UpdateCommandHint();
        }





        private void ExecuteButton_OnClick(object sender, EventArgs e)
        {
            string result = ATA4.RequestCommand(ExecuteTarget, ExecuteCommand);
            WriteOutput(result);
        }




        private void UpdateCommandHint()
        {
            int idx = this.CommandParamCombo.SelectedIndex;

            if (idx >= 0 && idx <= ATA4.IDLearn)
            {
                string[] CommandHintList = new string[] 
                {
                "<command> defaults to help, the same as using the -h parameter.",
                "<List> Lists all objects and files in a tabular form.",
                "<Info> Outputs various information for asset and asset bundle files.",
                "<Info-Stats> Outputs class usage statistics for asset files.",
                "<Dump> Converts the asset file to plain text, similar to the binary2text tool shipped with the Unity editor.",
                "<Dump-Struct> Like dump, but just for the data structure.",
                "<Extract> Extracts supported asset content and stores it in regular files. Default command if the -c parameter is omitted.",
                "<Extract-Raw> Extracts the raw serialized binary data from the asset.",
                "<FixRefs> Converts the relative paths for shared assets in compiled scene files to absolute paths. This allows the scenes to be opened in the Unity editor properly. NOTE: If the file and its dependencies are moved to a different folder, disunity needs to be run again with this command.",
                "<Split> Attempts to split an asset file to multiple smaller asset files, usually one for each object.",
                "<Unbundle> Extracts Unity webplayer bundles (*.unity3d).",
                "<Learn> Learns the structure from an Unity webplayer bundle (*.unity3d) and stores any new structs in the database file structdb.dat. Its data is required to deserialize standalone asset files, which usually don't contain any structure data." 
                };
                this.CommandParamHintTextBox.Text = CommandHintList[idx];
            } else {
                this.CommandParamHintTextBox.Text = "No hints available, sorry :(";
            }
        }



    }
}
