using System;
using System.Windows.Forms;

namespace GuessMelody
{
	public partial class FormGame : Form
	{

		Random rand = new Random();

		public FormGame()
		{
			InitializeComponent();
		}

		void PlayMusic()
		{
			int currSong = rand.Next(0, AppData.songList.Count);
			axWindowsMediaPlayer.URL = AppData.songList[currSong];
			//axWindowsMediaPlayer.Ctlcontrols.play();
			AppData.songList.RemoveAt(currSong);
			labelSongsCount.Text = AppData.songList.Count.ToString();
		}

		private void buttonNext_Click(object sender, EventArgs e)
		{
			PlayMusic();
			timerGameDuration.Start();
		}

		private void FormGame_FormClosing(object sender, FormClosingEventArgs e)
		{
			axWindowsMediaPlayer.Ctlcontrols.stop();
			timerGameDuration.Stop();
		}

		private void FormGame_Load(object sender, EventArgs e)
		{
			labelSongsCount.Text = AppData.songList.Count.ToString();
			progressBarGameDuration.Minimum = 0;
			progressBarGameDuration.Value = 0;
			progressBarGameDuration.Maximum = AppData.gameDuration;
		}

		private void timerGameDuration_Tick(object sender, EventArgs e)
		{
			progressBarGameDuration.Value++;
			if (progressBarGameDuration.Value >= progressBarGameDuration.Maximum)
			{
				timerGameDuration.Stop();
			}
		}

		private void buttonPause_Click(object sender, EventArgs e)
		{
			timerGameDuration.Stop();
			axWindowsMediaPlayer.Ctlcontrols.pause();
		}

		private void buttonContinue_Click(object sender, EventArgs e)
		{
			timerGameDuration.Start();
			axWindowsMediaPlayer.Ctlcontrols.play();
		}
	}
}
