namespace GuessMelody
{
	partial class FormGame
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
			this.axWMPlayer = new AxWMPLib.AxWindowsMediaPlayer();
			this.buttonNext = new System.Windows.Forms.Button();
			this.labelScore1 = new System.Windows.Forms.Label();
			this.labelScore2 = new System.Windows.Forms.Label();
			this.buttonPause = new System.Windows.Forms.Button();
			this.buttonContinue = new System.Windows.Forms.Button();
			this.labelSongsCount = new System.Windows.Forms.Label();
			this.progressBarGameDuration = new System.Windows.Forms.ProgressBar();
			this.timerGameDuration = new System.Windows.Forms.Timer(this.components);
			this.progressBarMusicDuration = new System.Windows.Forms.ProgressBar();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxPlayer2Name = new System.Windows.Forms.TextBox();
			this.textBoxPlayer1Name = new System.Windows.Forms.TextBox();
			this.comboBoxPlayer2Key = new System.Windows.Forms.ComboBox();
			this.comboBoxPlayer1Key = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.axWMPlayer)).BeginInit();
			this.SuspendLayout();
			// 
			// axWMPlayer
			// 
			this.axWMPlayer.Enabled = true;
			this.axWMPlayer.Location = new System.Drawing.Point(-1, 398);
			this.axWMPlayer.Name = "axWMPlayer";
			this.axWMPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMPlayer.OcxState")));
			this.axWMPlayer.Size = new System.Drawing.Size(75, 23);
			this.axWMPlayer.TabIndex = 0;
			this.axWMPlayer.Visible = false;
			this.axWMPlayer.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.axWindowsMediaPlayer_OpenStateChange);
			// 
			// buttonNext
			// 
			this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonNext.Location = new System.Drawing.Point(69, 344);
			this.buttonNext.Name = "buttonNext";
			this.buttonNext.Size = new System.Drawing.Size(179, 48);
			this.buttonNext.TabIndex = 1;
			this.buttonNext.Text = "Следующая";
			this.buttonNext.UseVisualStyleBackColor = true;
			this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
			// 
			// labelScore1
			// 
			this.labelScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelScore1.Location = new System.Drawing.Point(123, 148);
			this.labelScore1.Name = "labelScore1";
			this.labelScore1.Size = new System.Drawing.Size(125, 31);
			this.labelScore1.TabIndex = 4;
			this.labelScore1.Text = "0";
			this.labelScore1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelScore1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelPoints_MouseClick);
			// 
			// labelScore2
			// 
			this.labelScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelScore2.Location = new System.Drawing.Point(413, 148);
			this.labelScore2.Name = "labelScore2";
			this.labelScore2.Size = new System.Drawing.Size(125, 31);
			this.labelScore2.TabIndex = 5;
			this.labelScore2.Text = "0";
			this.labelScore2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelScore2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelPoints_MouseClick);
			// 
			// buttonPause
			// 
			this.buttonPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonPause.Location = new System.Drawing.Point(311, 344);
			this.buttonPause.Name = "buttonPause";
			this.buttonPause.Size = new System.Drawing.Size(179, 48);
			this.buttonPause.TabIndex = 6;
			this.buttonPause.Text = "Пауза";
			this.buttonPause.UseVisualStyleBackColor = true;
			this.buttonPause.Visible = false;
			this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
			// 
			// buttonContinue
			// 
			this.buttonContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonContinue.Location = new System.Drawing.Point(311, 344);
			this.buttonContinue.Name = "buttonContinue";
			this.buttonContinue.Size = new System.Drawing.Size(179, 48);
			this.buttonContinue.TabIndex = 7;
			this.buttonContinue.Text = "Продолжить";
			this.buttonContinue.UseVisualStyleBackColor = true;
			this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
			// 
			// labelSongsCount
			// 
			this.labelSongsCount.AutoSize = true;
			this.labelSongsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelSongsCount.Location = new System.Drawing.Point(257, 295);
			this.labelSongsCount.Name = "labelSongsCount";
			this.labelSongsCount.Size = new System.Drawing.Size(20, 24);
			this.labelSongsCount.TabIndex = 8;
			this.labelSongsCount.Text = "0";
			// 
			// progressBarGameDuration
			// 
			this.progressBarGameDuration.Location = new System.Drawing.Point(16, 44);
			this.progressBarGameDuration.Name = "progressBarGameDuration";
			this.progressBarGameDuration.Size = new System.Drawing.Size(545, 39);
			this.progressBarGameDuration.Step = 1;
			this.progressBarGameDuration.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBarGameDuration.TabIndex = 9;
			// 
			// timerGameDuration
			// 
			this.timerGameDuration.Interval = 1000;
			this.timerGameDuration.Tick += new System.EventHandler(this.timerGameDuration_Tick);
			// 
			// progressBarMusicDuration
			// 
			this.progressBarMusicDuration.Location = new System.Drawing.Point(9, 260);
			this.progressBarMusicDuration.Name = "progressBarMusicDuration";
			this.progressBarMusicDuration.Size = new System.Drawing.Size(545, 32);
			this.progressBarMusicDuration.Step = 1;
			this.progressBarMusicDuration.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBarMusicDuration.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(8, 295);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(215, 24);
			this.label1.TabIndex = 11;
			this.label1.Text = "Композиций осталось:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(243, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 31);
			this.label2.TabIndex = 12;
			this.label2.Text = "Игра";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(186, 233);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(202, 24);
			this.label3.TabIndex = 13;
			this.label3.Text = "Текущая композиция:";
			// 
			// textBoxPlayer2Name
			// 
			this.textBoxPlayer2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxPlayer2Name.Location = new System.Drawing.Point(311, 103);
			this.textBoxPlayer2Name.Name = "textBoxPlayer2Name";
			this.textBoxPlayer2Name.Size = new System.Drawing.Size(250, 38);
			this.textBoxPlayer2Name.TabIndex = 17;
			this.textBoxPlayer2Name.Text = "Игрок 2";
			this.textBoxPlayer2Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBoxPlayer1Name
			// 
			this.textBoxPlayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxPlayer1Name.Location = new System.Drawing.Point(16, 103);
			this.textBoxPlayer1Name.Name = "textBoxPlayer1Name";
			this.textBoxPlayer1Name.Size = new System.Drawing.Size(250, 38);
			this.textBoxPlayer1Name.TabIndex = 16;
			this.textBoxPlayer1Name.Text = "Игрок 1";
			this.textBoxPlayer1Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// comboBoxPlayer2Key
			// 
			this.comboBoxPlayer2Key.FormattingEnabled = true;
			this.comboBoxPlayer2Key.Items.AddRange(new object[] {
            "2",
            "J",
            "K",
            "L"});
			this.comboBoxPlayer2Key.Location = new System.Drawing.Point(436, 186);
			this.comboBoxPlayer2Key.MaxLength = 1;
			this.comboBoxPlayer2Key.Name = "comboBoxPlayer2Key";
			this.comboBoxPlayer2Key.Size = new System.Drawing.Size(62, 21);
			this.comboBoxPlayer2Key.TabIndex = 15;
			this.comboBoxPlayer2Key.Text = "P";
			// 
			// comboBoxPlayer1Key
			// 
			this.comboBoxPlayer1Key.FormattingEnabled = true;
			this.comboBoxPlayer1Key.Items.AddRange(new object[] {
            "1",
            "A",
            "S",
            "D"});
			this.comboBoxPlayer1Key.Location = new System.Drawing.Point(135, 186);
			this.comboBoxPlayer1Key.MaxLength = 1;
			this.comboBoxPlayer1Key.Name = "comboBoxPlayer1Key";
			this.comboBoxPlayer1Key.Size = new System.Drawing.Size(62, 21);
			this.comboBoxPlayer1Key.TabIndex = 14;
			this.comboBoxPlayer1Key.Text = "A";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(31, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 31);
			this.label4.TabIndex = 18;
			this.label4.Text = "Очки:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(321, 148);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 31);
			this.label5.TabIndex = 19;
			this.label5.Text = "Очки:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(16, 189);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(113, 13);
			this.label6.TabIndex = 20;
			this.label6.Text = "Клавиша для ответа:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(308, 189);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(113, 13);
			this.label7.TabIndex = 21;
			this.label7.Text = "Клавиша для ответа:";
			// 
			// FormGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(576, 404);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxPlayer2Name);
			this.Controls.Add(this.textBoxPlayer1Name);
			this.Controls.Add(this.comboBoxPlayer2Key);
			this.Controls.Add(this.comboBoxPlayer1Key);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.progressBarMusicDuration);
			this.Controls.Add(this.progressBarGameDuration);
			this.Controls.Add(this.labelSongsCount);
			this.Controls.Add(this.buttonContinue);
			this.Controls.Add(this.buttonPause);
			this.Controls.Add(this.labelScore2);
			this.Controls.Add(this.labelScore1);
			this.Controls.Add(this.buttonNext);
			this.Controls.Add(this.axWMPlayer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "FormGame";
			this.Text = "Игра";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGame_FormClosing);
			this.Load += new System.EventHandler(this.FormGame_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.axWMPlayer)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private AxWMPLib.AxWindowsMediaPlayer axWMPlayer;
		private System.Windows.Forms.Button buttonNext;
		private System.Windows.Forms.Label labelScore1;
		private System.Windows.Forms.Label labelScore2;
		private System.Windows.Forms.Button buttonPause;
		private System.Windows.Forms.Button buttonContinue;
		private System.Windows.Forms.Label labelSongsCount;
		private System.Windows.Forms.ProgressBar progressBarGameDuration;
		private System.Windows.Forms.Timer timerGameDuration;
		private System.Windows.Forms.ProgressBar progressBarMusicDuration;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxPlayer2Name;
		private System.Windows.Forms.TextBox textBoxPlayer1Name;
		private System.Windows.Forms.ComboBox comboBoxPlayer2Key;
		private System.Windows.Forms.ComboBox comboBoxPlayer1Key;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
	}
}