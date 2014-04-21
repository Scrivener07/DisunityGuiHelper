using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;



namespace DisunityGuiHelper
{
	public partial class ToolWindow
	{

		public const string typefilter_ALL = "All Files (*.*)|*.*";
		public const string typefilter_UNITY = "Unity Files |*.*";
		public const string typefilter_TEXT = "Text |*.txt|Any File|*.*";


		private string ShowFolderBrowser(bool a_addPathSeperator = false)
		{
			if (this.BrowseFolderDialog.ShowDialog() == DialogResult.OK)
			{
				if (a_addPathSeperator)
				{
					return this.BrowseFolderDialog.SelectedPath + "\\";
				}
				else
				{
					return this.BrowseFolderDialog.SelectedPath;
				}
			}
			else
			{
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
			}
			else
			{
				return null;
			}
		}



		private bool ShowSaveFileBrowser(object data, string filter = typefilter_TEXT)
		{
			this.SaveFileDialog.FileName = "DisunityReport";
			this.SaveFileDialog.Filter = filter;

			if (this.SaveFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (StreamWriter sw = new StreamWriter(SaveFileDialog.FileName))  
				{
					sw.Write(data);  
					sw.Flush();  
					sw.Close();
					return true;
				}  
			}
			else
			{
				return false;
			}
		}


	}
}
