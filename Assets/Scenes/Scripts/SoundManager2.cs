using UnityEngine;

public class SoundManager2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public AudioSource sfxSource1;
    public AudioClip endSfx1;


    private void Start()
    {
        sfxSource1.PlayOneShot(endSfx1);
    }

}
