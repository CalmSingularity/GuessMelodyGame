namespace GuessMelody
{
	partial class FormPreferences
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
			this.listBoxSongs = new System.Windows.Forms.ListBox();
			this.buttonChooseFolder = new System.Windows.Forms.Button();
			this.buttonClearList = new System.Windows.Forms.Button();
			this.checkBoxAllDirs = new System.Windows.Forms.CheckBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.groupBoxPreferences = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxGameDuration = new System.Windows.Forms.ComboBox();
			this.comboBoxMusicDuration = new System.Windows.Forms.ComboBox();
			this.checkBoxRandomStart = new System.Windows.Forms.CheckBox();
			this.groupBoxPreferences.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBoxSongs
			// 
			this.listBoxSongs.Dock = System.Windows.Forms.DockStyle.Top;
			this.listBoxSongs.FormattingEnabled = true;
			this.listBoxSongs.Location = new System.Drawing.Point(0, 0);
			this.listBoxSongs.Name = "listBoxSongs";
			this.listBoxSongs.Size = new System.Drawing.Size(618, 264);
			this.listBoxSongs.TabIndex = 0;
			// 
			// buttonChooseFolder
			// 
			this.buttonChooseFolder.Location = new System.Drawing.Point(14, 270);
			this.buttonChooseFolder.Name = "buttonChooseFolder";
			this.buttonChooseFolder.Size = new System.Drawing.Size(150, 23);
			this.buttonChooseFolder.TabIndex = 1;
			this.buttonChooseFolder.Text = "Выбрать папку...";
			this.buttonChooseFolder.UseVisualStyleBackColor = true;
			this.buttonChooseFolder.Click += new System.EventHandler(this.buttonChooseFolder_Click);
			// 
			// buttonClearList
			// 
			this.buttonClearList.Location = new System.Drawing.Point(170, 270);
			this.buttonClearList.Name = "buttonClearList";
			this.buttonClearList.Size = new System.Drawing.Size(150, 23);
			this.buttonClearList.TabIndex = 2;
			this.buttonClearList.Text = "Очистить список";
			this.buttonClearList.UseVisualStyleBackColor = true;
			// 
			// checkBoxAllDirs
			// 
			this.checkBoxAllDirs.AutoSize = true;
			this.checkBoxAllDirs.Checked = true;
			this.checkBoxAllDirs.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxAllDirs.Location = new System.Drawing.Point(346, 274);
			this.checkBoxAllDirs.Name = "checkBoxAllDirs";
			this.checkBoxAllDirs.Size = new System.Drawing.Size(118, 17);
			this.checkBoxAllDirs.TabIndex = 3;
			this.checkBoxAllDirs.Text = "Вложенные папки";
			this.checkBoxAllDirs.UseVisualStyleBackColor = true;
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(531, 402);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 4;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(531, 431);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// groupBoxPreferences
			// 
			this.groupBoxPreferences.Controls.Add(this.checkBoxRandomStart);
			this.groupBoxPreferences.Controls.Add(this.comboBoxMusicDuration);
			this.groupBoxPreferences.Controls.Add(this.comboBoxGameDuration);
			this.groupBoxPreferences.Controls.Add(this.label2);
			this.groupBoxPreferences.Controls.Add(this.label1);
			this.groupBoxPreferences.Location = new System.Drawing.Point(14, 310);
			this.groupBoxPreferences.Name = "groupBoxPreferences";
			this.groupBoxPreferences.Size = new System.Drawing.Size(306, 144);
			this.groupBoxPreferences.TabIndex = 6;
			this.groupBoxPreferences.TabStop = false;
			this.groupBoxPreferences.Text = "Настройки игры";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Продолжительность игры";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Время на ответ";
			// 
			// comboBoxGameDuration
			// 
			this.comboBoxGameDuration.FormattingEnabled = true;
			this.comboBoxGameDuration.Items.AddRange(new object[] {
            "30",
            "45",
            "60",
            "90",
            "120"});
			this.comboBoxGameDuration.Location = new System.Drawing.Point(165, 27);
			this.comboBoxGameDuration.Name = "comboBoxGameDuration";
			this.comboBoxGameDuration.Size = new System.Drawing.Size(77, 21);
			this.comboBoxGameDuration.TabIndex = 2;
			this.comboBoxGameDuration.Text = "60";
			// 
			// comboBoxMusicDuration
			// 
			this.comboBoxMusicDuration.FormattingEnabled = true;
			this.comboBoxMusicDuration.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45"});
			this.comboBoxMusicDuration.Location = new System.Drawing.Point(165, 50);
			this.comboBoxMusicDuration.Name = "comboBoxMusicDuration";
			this.comboBoxMusicDuration.Size = new System.Drawing.Size(77, 21);
			this.comboBoxMusicDuration.TabIndex = 3;
			this.comboBoxMusicDuration.Text = "20";
			// 
			// checkBoxRandomStart
			// 
			this.checkBoxRandomStart.AutoSize = true;
			this.checkBoxRandomStart.Checked = true;
			this.checkBoxRandomStart.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxRandomStart.Location = new System.Drawing.Point(9, 77);
			this.checkBoxRandomStart.Name = "checkBoxRandomStart";
			this.checkBoxRandomStart.Size = new System.Drawing.Size(236, 17);
			this.checkBoxRandomStart.TabIndex = 4;
			this.checkBoxRandomStart.Text = "Играть композиции со случайного места";
			this.checkBoxRandomStart.UseVisualStyleBackColor = true;
			// 
			// FormPreferences
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(618, 466);
			this.Controls.Add(this.groupBoxPreferences);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.checkBoxAllDirs);
			this.Controls.Add(this.buttonClearList);
			this.Controls.Add(this.buttonChooseFolder);
			this.Controls.Add(this.listBoxSongs);
			this.Name = "FormPreferences";
			this.Text = "Настройки";
			this.Load += new System.EventHandler(this.FormPreferences_Load);
			this.groupBoxPreferences.ResumeLayout(false);
			this.groupBoxPreferences.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxSongs;
		private System.Windows.Forms.Button buttonChooseFolder;
		private System.Windows.Forms.Button buttonClearList;
		private System.Windows.Forms.CheckBox checkBoxAllDirs;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.GroupBox groupBoxPreferences;
		private System.Windows.Forms.ComboBox comboBoxMusicDuration;
		private System.Windows.Forms.ComboBox comboBoxGameDuration;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBoxRandomStart;
	}
}