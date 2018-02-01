using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Win32;

namespace GuessMelody
{
	static class GameData
	{
		static public List<string> songList = new List<string>();
		static public int gameDuration = 60;
		static public int musicDuration = 10;
		static public int timeToAnswer = 3;
		static public bool randomStart = false;
		static public string lastFolder = "";
		static public bool allDirectories = true;

		static public string player1Name = "Игрок 1", player2Name = "Игрок 2";

		static public void ReadMusicList()
		{
			try
			{
				string[] fileList = Directory.GetFiles(lastFolder, "*.mp3",
						allDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
				songList.Clear();
				songList.AddRange(fileList);
			}
			catch { }
		}

		static string regKeyName = "Software\\PandaSoft\\GuessMelody";

		public static void WritePreferences()
		{
			RegistryKey registryKey = null;
			try
			{
				registryKey = Registry.CurrentUser.CreateSubKey(regKeyName);
				if (registryKey == null) { return; }
				registryKey.SetValue("LastFolder", lastFolder);
				registryKey.SetValue("RandomStart", randomStart);
				registryKey.SetValue("GameDuration", gameDuration);
				registryKey.SetValue("MusicDuration", musicDuration);
				registryKey.SetValue("TimeToAnswer", timeToAnswer);
				registryKey.SetValue("AllDirectories", allDirectories);
			}
			finally
			{
				if (registryKey != null)
				{
					registryKey.Close();
				}
			}
		}

		public static void ReadPreferences()
		{
			RegistryKey registryKey = null;
			try
			{
				registryKey = Registry.CurrentUser.OpenSubKey(regKeyName);
				if (registryKey != null)
				{
					lastFolder = (string)registryKey.GetValue("LastFolder");
					randomStart = Convert.ToBoolean(registryKey.GetValue("RandomStart", true));
					gameDuration = (int)registryKey.GetValue("GameDuration");
					musicDuration = (int)registryKey.GetValue("MusicDuration");
					timeToAnswer = (int)registryKey.GetValue("TimeToAnswer");
					allDirectories = Convert.ToBoolean(registryKey.GetValue("AllDirectories", true));
				}

			}
			finally
			{
				if (registryKey != null)
				{
					registryKey.Close();
				}
			}
		}
	}
}
