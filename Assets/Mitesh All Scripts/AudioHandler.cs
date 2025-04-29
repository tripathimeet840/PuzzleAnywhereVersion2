using UnityEngine;
using UnityEngine.UI;

public class AudioHandler : MonoBehaviour
{
   public static AudioHandler Instance;

    public AudioSource backGroundMusic;
    public AudioSource audiosource;

    public AudioClip clicksound;

    public GameObject soundOnBtn;


    private void Awake()
    {
        if(Instance == null)    
            Instance = this;
    }

    public void OffBackgroundSound(bool ismute)
    {
        soundOnBtn.SetActive(true);
        backGroundMusic.mute = ismute;
    }

    public void OnBackgroundSound(bool ismute)
    {
        soundOnBtn.SetActive(false);    
        backGroundMusic.mute = ismute;
    }

    public void GameplaySound(AudioClip audioclip)
    {
        audiosource.clip = audioclip;
        audiosource.Play();
    }
}
