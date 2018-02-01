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
			this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
			this.buttonNext = new System.Windows.Forms.Button();
			this.labelPlayer1 = new System.Windows.Forms.Label();
			this.labelPlayer2 = new System.Windows.Forms.Label();
			this.labelPoints1 = new System.Windows.Forms.Label();
			this.labelPoints2 = new System.Windows.Forms.Label();
			this.buttonPause = new System.Windows.Forms.Button();
			this.buttonContinue = new System.Windows.Forms.Button();
			this.labelSongsCount = new System.Windows.Forms.Label();
			this.progressBarGameDuration = new System.Windows.Forms.ProgressBar();
			this.timerGameDuration = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
			this.SuspendLayout();
			// 
			// axWindowsMediaPlayer
			// 
			this.axWindowsMediaPlayer.Enabled = true;
			this.axWindowsMediaPlayer.Location = new System.Drawing.Point(-4, 337);
			this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
			this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
			this.axWindowsMediaPlayer.Size = new System.Drawing.Size(75, 23);
			this.axWindowsMediaPlayer.TabIndex = 0;
			this.axWindowsMediaPlayer.Visible = false;
			// 
			// buttonNext
			// 
			this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonNext.Location = new System.Drawing.Point(12, 270);
			this.buttonNext.Name = "buttonNext";
			this.buttonNext.Size = new System.Drawing.Size(179, 48);
			this.buttonNext.TabIndex = 1;
			this.buttonNext.Text = "Следующая";
			this.buttonNext.UseVisualStyleBackColor = true;
			this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
			// 
			// labelPlayer1
			// 
			this.labelPlayer1.AutoSize = true;
			this.labelPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelPlayer1.Location = new System.Drawing.Point(81, 26);
			this.labelPlayer1.Name = "labelPlayer1";
			this.labelPlayer1.Size = new System.Drawing.Size(110, 31);
			this.labelPlayer1.TabIndex = 2;
			this.labelPlayer1.Text = "Игрок 1";
			// 
			// labelPlayer2
			// 
			this.labelPlayer2.AutoSize = true;
			this.labelPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelPlayer2.Location = new System.Drawing.Point(373, 26);
			this.labelPlayer2.Name = "labelPlayer2";
			this.labelPlayer2.Size = new System.Drawing.Size(110, 31);
			this.labelPlayer2.TabIndex = 3;
			this.labelPlayer2.Text = "Игрок 2";
			// 
			// labelPoints1
			// 
			this.labelPoints1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelPoints1.Location = new System.Drawing.Point(66, 69);
			this.labelPoints1.Name = "labelPoints1";
			this.labelPoints1.Size = new System.Drawing.Size(125, 43);
			this.labelPoints1.TabIndex = 4;
			this.labelPoints1.Text = "0";
			this.labelPoints1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelPoints2
			// 
			this.labelPoints2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelPoints2.Location = new System.Drawing.Point(358, 69);
			this.labelPoints2.Name = "labelPoints2";
			this.labelPoints2.Size = new System.Drawing.Size(125, 43);
			this.labelPoints2.TabIndex = 5;
			this.labelPoints2.Text = "0";
			this.labelPoints2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonPause
			// 
			this.buttonPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonPause.Location = new System.Drawing.Point(194, 270);
			this.buttonPause.Name = "buttonPause";
			this.buttonPause.Size = new System.Drawing.Size(179, 48);
			this.buttonPause.TabIndex = 6;
			this.buttonPause.Text = "Пауза";
			this.buttonPause.UseVisualStyleBackColor = true;
			this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
			// 
			// buttonContinue
			// 
			this.buttonContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonContinue.Location = new System.Drawing.Point(379, 270);
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
			this.labelSongsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelSongsCount.Location = new System.Drawing.Point(254, 98);
			this.labelSongsCount.Name = "labelSongsCount";
			this.labelSongsCount.Size = new System.Drawing.Size(24, 25);
			this.labelSongsCount.TabIndex = 8;
			this.labelSongsCount.Text = "0";
			// 
			// progressBarGameDuration
			// 
			this.progressBarGameDuration.Location = new System.Drawing.Point(13, 172);
			this.progressBarGameDuration.Name = "progressBarGameDuration";
			this.progressBarGameDuration.Size = new System.Drawing.Size(545, 40);
			this.progressBarGameDuration.Step = 1;
			this.progressBarGameDuration.TabIndex = 9;
			// 
			// timerGameDuration
			// 
			this.timerGameDuration.Interval = 1000;
			this.timerGameDuration.Tick += new System.EventHandler(this.timerGameDuration_Tick);
			// 
			// FormGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(570, 357);
			this.Controls.Add(this.progressBarGameDuration);
			this.Controls.Add(this.labelSongsCount);
			this.Controls.Add(this.buttonContinue);
			this.Controls.Add(this.buttonPause);
			this.Controls.Add(this.labelPoints2);
			this.Controls.Add(this.labelPoints1);
			this.Controls.Add(this.labelPlayer2);
			this.Controls.Add(this.labelPlayer1);
			this.Controls.Add(this.buttonNext);
			this.Controls.Add(this.axWindowsMediaPlayer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormGame";
			this.Text = "Игра";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGame_FormClosing);
			this.Load += new System.EventHandler(this.FormGame_Load);
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
		private System.Windows.Forms.Button buttonNext;
		private System.Windows.Forms.Label labelPlayer1;
		private System.Windows.Forms.Label labelPlayer2;
		private System.Windows.Forms.Label labelPoints1;
		private System.Windows.Forms.Label labelPoints2;
		private System.Windows.Forms.Button buttonPause;
		private System.Windows.Forms.Button buttonContinue;
		private System.Windows.Forms.Label labelSongsCount;
		private System.Windows.Forms.ProgressBar progressBarGameDuration;
		private System.Windows.Forms.Timer timerGameDuration;
	}
}