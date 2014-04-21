using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Drawing;

namespace DisunityGuiHelper
{
	public partial class ToolWindow
	{

		private bool IsBusy = false;

		string hintExpert = "You are using expert mode.\n".Replace("\n", Environment.NewLine) +
			"In this mode you can execute any commands by typing them into the command field.\n".Replace("\n", Environment.NewLine) +
			"This tool will still provide the java and disunity arguments for you.\n".Replace("\n", Environment.NewLine) +
			"The gui will provide the target parameter as well if 'Use Target' is checked.".Replace("\n", Environment.NewLine);

		string WarnNoBatch = "Sorry, batch processing not implemented yet." +
			"You can use 'Expert Mode' or the standalone version of disunity to gain this functionality.";



		// Application Status
		///-----------------------------------------------------------------------------------
		private void SetBusyLight()
		{
			IsBusy = true;
			this.ExecuteButton.Enabled = false;
			this.ExecuteButton.Click -= ExecuteButton_OnClick;
			this.BusyIndicator.BackColor = Color.IndianRed;
			this.BusyStatusLabel.Text = "Busy";
			this.HelpHintTextbox.Text = "The application is busy processing your command..\nPlease dont try to interact with or exit this application until it is ready.".Replace("\n", Environment.NewLine);
			this.BusyIndicator.Refresh();
			this.BusyStatusLabel.Refresh();
			this.HelpHintTextbox.Refresh();
		}


		private void SetReadyLight()
		{
			this.ExecuteButton.Enabled = true;
			this.ExecuteButton.Click += ExecuteButton_OnClick;
			this.BusyIndicator.BackColor = Color.MediumSeaGreen;
			this.BusyStatusLabel.Text = "Ready";
			this.BusyIndicator.Refresh();
			this.BusyStatusLabel.Refresh();
			IsBusy = false;
			UpdateHint();
		}




		// Support
		///-----------------------------------------------------------------------------------
		private void SupportButton_OnClick(object sender, EventArgs e)
		{
			if (true)
			{
				this.WriteOutput(ATA4.ShowHintMessage());	
			}
		}


		private void UpdateHint()
		{
			if (UseExpert)
			{
				this.HelpHintTextbox.Text = hintExpert;
			}
			else
			{
				HelpHintTextbox.Text = DisunityHelper.CommandHintList[RunPresetSelection.SelectedIndex];
			}
		}



		public void WriteHint(string text)
		{
			this.HelpHintTextbox.Text += text;
			Debug.WriteLine(text);
		}



		private void EnableSupport(bool enable = true)
		{
			if (enable)
			{
				this.SupportButton.Enabled = true;
				this.SupportButton.Visible = true;
			}
			else
			{
				this.SupportButton.Enabled = false;
				this.SupportButton.Visible = false;
			}
		}



	}
}
