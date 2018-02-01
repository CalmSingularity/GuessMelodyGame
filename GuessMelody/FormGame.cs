using System;
using System.Threading;
using System.Windows.Forms;

namespace GuessMelody
{
	public partial class FormGame : Form
	{

		Random rand = new Random();
		string currSongFileName;
		//int scorePlayer1, scorePlayer2;

		public FormGame()
		{
			InitializeComponent();
			//scorePlayer1 = 0;
			//scorePlayer2 = 0;
		}

		void PlayNextSong()
		{
			if (GameData.songList.Count == 0)
			{
				GameOver();
			}
			else
			{
				progressBarMusicDuration.Value = 0;
				int currSong = rand.Next(0, GameData.songList.Count);
				currSongFileName = GameData.songList[currSong];
				axWMPlayer.URL = currSongFileName;
				GameData.songList.RemoveAt(currSong);
				labelSongsCount.Text = GameData.songList.Count.ToString();
			}
		}

		private void buttonNext_Click(object sender, EventArgs e)
		{
			PlayNextSong();
			GameContinue();
		}

		private void FormGame_FormClosing(object sender, FormClosingEventArgs e)
		{
			axWMPlayer.Ctlcontrols.stop();
			timerGameDuration.Stop();
			GameData.player1Name = textBoxPlayer1Name.Text;
			GameData.player2Name = textBoxPlayer2Name.Text;
		}

		private void FormGame_Load(object sender, EventArgs e)
		{
			labelSongsCount.Text = GameData.songList.Count.ToString();
			progressBarGameDuration.Minimum = 0;
			progressBarGameDuration.Value = 0;
			progressBarGameDuration.Maximum = GameData.gameDuration;
			progressBarMusicDuration.Minimum = 0;
			progressBarMusicDuration.Value = 0;
			progressBarMusicDuration.Maximum = GameData.musicDuration;
			textBoxPlayer1Name.Text = GameData.player1Name;
			textBoxPlayer2Name.Text = GameData.player2Name;
		}

		private void timerGameDuration_Tick(object sender, EventArgs e)
		{
			if (progressBarGameDuration.Value < progressBarGameDuration.Maximum)
			{
				progressBarGameDuration.Value++;
			}
			else
			{
				GameOver();
				return;
			}

			if (progressBarMusicDuration.Value < progressBarMusicDuration.Maximum)
			{
				progressBarMusicDuration.Value++;
			}
			else
			{
				PlayNextSong();
			}
		}

		void GameOver()
		{
			timerGameDuration.Stop();
			axWMPlayer.Ctlcontrols.stop();
			int scorePlayer1 = Convert.ToInt32(labelScore1.Text);
			int scorePlayer2 = Convert.ToInt32(labelScore2.Text);
			if (scorePlayer1 > scorePlayer2)
			{
				MessageBox.Show($"Победил {textBoxPlayer1Name.Text}", "Игра окончена", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else if (scorePlayer1 < scorePlayer2)
			{
				MessageBox.Show($"Победил {textBoxPlayer2Name.Text}", "Игра окончена", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			} 
			else
			{
				MessageBox.Show($"Игроки набрали равное количество очков", "Игра окончена", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			this.Close();
		}

		private void buttonPause_Click(object sender, EventArgs e)
		{
			GamePause();
		}

		private void buttonContinue_Click(object sender, EventArgs e)
		{
			GameContinue();
		}

		void GamePause()
		{
			timerGameDuration.Stop();
			axWMPlayer.Ctlcontrols.pause();
			buttonPause.Visible = false;
			buttonContinue.Visible = true;
			comboBoxPlayer1Key.Enabled = true;
			comboBoxPlayer2Key.Enabled = true;
			textBoxPlayer1Name.Enabled = true;
			textBoxPlayer2Name.Enabled = true;
		}

		void GameContinue()
		{
			timerGameDuration.Start();
			axWMPlayer.Ctlcontrols.play();
			buttonPause.Visible = true;
			buttonContinue.Visible = false;
			comboBoxPlayer1Key.Enabled = false;
			comboBoxPlayer2Key.Enabled = false;
			textBoxPlayer1Name.Enabled = false;
			textBoxPlayer2Name.Enabled = false;
		}

		private void FormGame_KeyDown(object sender, KeyEventArgs e)
		{
			string pressedKey = e.KeyData.ToString();
			if (pressedKey.Length == 2 && pressedKey[0] == 'D')
			{
				pressedKey = pressedKey[1].ToString();
			}

			if (!timerGameDuration.Enabled) { return; } // players cannot answer when game is not in progress
			var currMP3file = TagLib.File.Create(currSongFileName);

			if (pressedKey == comboBoxPlayer1Key.Text)
			{
				GamePause();
				Thread.Sleep(GameData.timeToAnswer * 1000);
				if (MessageBox.Show($"{currMP3file.Tag.FirstPerformer} - {currMP3file.Tag.Title}\nПравильный ответ?",
					textBoxPlayer1Name.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
					== DialogResult.Yes)
				{
					labelScore1.Text = Convert.ToString(Convert.ToInt32(labelScore1.Text) + 1);
					PlayNextSong();
				}
				GameContinue();
			}
			if (pressedKey == comboBoxPlayer2Key.Text)
			{
				GamePause();
				Thread.Sleep(GameData.timeToAnswer * 1000);
				if (MessageBox.Show($"{currMP3file.Tag.FirstPerformer} - {currMP3file.Tag.Title}\nПравильный ответ?",
					textBoxPlayer2Name.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
					== DialogResult.Yes)
				{
					labelScore2.Text = Convert.ToString(Convert.ToInt32(labelScore2.Text) + 1);
					PlayNextSong();
				}
				GameContinue();
			}
		}

		private void axWindowsMediaPlayer_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
		{
			if (GameData.randomStart)
			{
				if (axWMPlayer.openState == WMPLib.WMPOpenState.wmposMediaOpen)
				{
					axWMPlayer.Ctlcontrols.currentPosition = rand.Next(0, (int)axWMPlayer.currentMedia.duration - GameData.musicDuration - 15);
				}
			}
		}

		private void labelPoints_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				(sender as Label).Text = Convert.ToString(Convert.ToInt32((sender as Label).Text) + 1);
			}
			else if (e.Button == MouseButtons.Right)
			{
				(sender as Label).Text = Convert.ToString(Convert.ToInt32((sender as Label).Text) - 1);
			}
		}
	}
}
