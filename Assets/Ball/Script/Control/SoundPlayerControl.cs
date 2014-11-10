using UnityEngine;
using System.Collections;

public class SoundPlayerControl : MonoBehaviour 
{
    private AudioSource BGM;
    private AudioSource SFX;

	void Start () 
    {
        SFX = gameObject.AddComponent<AudioSource>();
        BGM = gameObject.AddComponent<AudioSource>();
        BGM.loop = true;
        CheckEnable();
	}
	
	void PlayBGM(AudioClip AC)
    {
        BGM.clip = AC;
        BGM.Play();
    }

    void PlaySFX(AudioClip AC)
    {
        SFX.PlayOneShot(AC);    
    }

    void CheckEnable()
    {
        if (GameCore.GetInstance.GameSetting.Music != BGM.enabled)
        {
            BGM.enabled = GameCore.GetInstance.GameSetting.Music;
        }
        if (GameCore.GetInstance.GameSetting.Sound != SFX.enabled)
        {
            SFX.enabled = GameCore.GetInstance.GameSetting.Sound;
        }
    }
}
