using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class GameCore  
{   
	private static GameCore Instance = new GameCore();
	static GameCore() { Instance.Initialize(); }
	public static GameCore GetInstance { get { return Instance; } }
	
	public class Setting
	{
		private bool Setting_Music;
		private bool Setting_Sound;
		
		public bool Sound
		{
			get { return Setting_Sound; }
			set
			{
				Setting_Sound = value;
				PlayerPrefs.SetInt("Sound", Convert.ToInt32(!value));
			}
		}
		
		public bool Music
		{
			get { return Setting_Music; }
			set
			{
				Setting_Music = value;
				PlayerPrefs.SetInt("Music", Convert.ToInt32(!value));
			}
		}
		
		public void LoadSetting()
		{
			Setting_Music = (0 == PlayerPrefs.GetInt("Music"));
			Setting_Sound = (0 == PlayerPrefs.GetInt("Sound"));
		}
	}
	
	public Setting _GameSetting = new Setting();

	public bool PlayScene;
	public int Level;
	
	public Setting GameSetting { get { return _GameSetting; } }

	
	private void Initialize()
	{
		GameSetting.LoadSetting();
	}
}
