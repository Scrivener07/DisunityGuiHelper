using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


namespace Barracuda
{
    public partial class ToolWindow
    {

        public const string typefilter_ALL = "All Files (*.*)|*.*";
        public const string typefilter_UNITY = "Unity Files |*.*";



        private string ShowFolderBrowser(bool a_addPathSeperator = false)
        {
            if (this.BrowseFolderDialog.ShowDialog() == DialogResult.OK)
            {
                if (a_addPathSeperator)
                {
                    return this.BrowseFolderDialog.SelectedPath + "\\";
                } else {
                    return this.BrowseFolderDialog.SelectedPath;
                }
            } else {
                return null;
            }
        }



        private string ShowFileBrowser(string filter = typefilter_ALL)
        {
            this.BrowseFileDialog.FileName = null;
            this.BrowseFileDialog.Filter = filter;
            if (this.BrowseFileDialog.ShowDialog() == DialogResult.OK)
            {
                return this.BrowseFileDialog.FileName;
            } else {
                return null;
            }
        }




    }
}
