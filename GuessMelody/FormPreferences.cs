using System;
using System.Windows.Forms;
using System.IO;

namespace GuessMelody
{
	public partial class FormPreferences : Form
	{
		public FormPreferences()
		{
			InitializeComponent();
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			AppData.allDirectories = checkBoxAllDirs.Checked;
			AppData.gameDuration = Convert.ToInt32(comboBoxGameDuration.Text);
			AppData.musicDuration = Convert.ToInt32(comboBoxMusicDuration.Text);
			AppData.randomStart = checkBoxRandomStart.Checked;
			AppData.WritePreferences();
			this.Hide();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			RefreshForm();
			this.Hide();
		}

		void RefreshForm()
		{
			checkBoxAllDirs.Checked = AppData.allDirectories;
			comboBoxGameDuration.Text = AppData.gameDuration.ToString();
			comboBoxMusicDuration.Text = AppData.musicDuration.ToString();
			checkBoxRandomStart.Checked = AppData.randomStart;
			string[] songList = Directory.GetFiles(AppData.lastFolder, "*.mp3",
				checkBoxAllDirs.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
			listBoxSongs.Items.Clear();
			listBoxSongs.Items.AddRange(songList);
		}

		private void buttonChooseFolder_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				string[] songList = Directory.GetFiles(folderBrowserDialog.SelectedPath, "*.mp3", 
					checkBoxAllDirs.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
				AppData.lastFolder = folderBrowserDialog.SelectedPath;
				listBoxSongs.Items.Clear();
				listBoxSongs.Items.AddRange(songList);
				AppData.songList.Clear();
				AppData.songList.AddRange(songList);
			}
			
		}

		private void FormPreferences_Load(object sender, EventArgs e)
		{
			RefreshForm();
		}
	}
}
