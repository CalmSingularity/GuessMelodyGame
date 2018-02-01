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
			GameData.allDirectories = checkBoxAllDirs.Checked;
			GameData.gameDuration = Convert.ToInt32(comboBoxGameDuration.Text);
			GameData.musicDuration = Convert.ToInt32(comboBoxMusicDuration.Text);
			GameData.randomStart = checkBoxRandomStart.Checked;
			GameData.WritePreferences();
			this.Hide();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			RefreshForm();
			this.Hide();
		}

		void RefreshForm()
		{
			checkBoxAllDirs.Checked = GameData.allDirectories;
			comboBoxGameDuration.Text = GameData.gameDuration.ToString();
			comboBoxMusicDuration.Text = GameData.musicDuration.ToString();
			checkBoxRandomStart.Checked = GameData.randomStart;
			string[] songList = Directory.GetFiles(GameData.lastFolder, "*.mp3",
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
				GameData.lastFolder = folderBrowserDialog.SelectedPath;
				listBoxSongs.Items.Clear();
				listBoxSongs.Items.AddRange(songList);
				GameData.songList.Clear();
				GameData.songList.AddRange(songList);
			}
			
		}

		private void FormPreferences_Load(object sender, EventArgs e)
		{
			RefreshForm();
		}
	}
}
