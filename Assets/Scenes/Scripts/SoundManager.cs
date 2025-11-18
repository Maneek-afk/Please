using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource backgroundMusic;
    public AudioSource sfxSource;

    public AudioClip fartsfx;

    public void PlayFartSound()
    {
        sfxSource.PlayOneShot(fartsfx);
    }

}
