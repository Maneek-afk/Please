using UnityEngine;


public class SoundManager : MonoBehaviour
{
    public AudioSource backgroundMusic;
    public AudioSource sfxSource;

    public AudioClip fartsfx;
    public AudioClip eatsfx;
    public AudioClip backgroundMusicClip;
    public AudioClip endSfx;

    void Start()
    {
        backgroundMusic.clip = backgroundMusicClip;
        backgroundMusic.loop = true;
        backgroundMusic.Play();
    }

    public void PlayFartSound()
    {
        sfxSource.PlayOneShot(fartsfx);
    }

    public void PlayEatSound()
    {
        sfxSource.PlayOneShot(eatsfx);
    }

    public void PlayEndSound()
    {
        sfxSource.PlayOneShot(endSfx);
    }
}
