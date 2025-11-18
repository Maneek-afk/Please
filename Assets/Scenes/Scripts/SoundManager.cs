using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource backgroundMusic;
    public AudioSource sfxSource;

    public AudioClip backgroundMusicClip;
    public AudioClip fartsfx;


    public void Start()
    {
        // Play background music on loop
        backgroundMusic.clip = backgroundMusicClip;
        backgroundMusic.loop = true;
        backgroundMusic.Play();
    }
    public void PlayFartSound()
    {
        sfxSource.PlayOneShot(fartsfx);
    }

}
