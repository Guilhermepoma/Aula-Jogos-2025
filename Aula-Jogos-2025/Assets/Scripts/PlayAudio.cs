using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip CoinSound;
    public AudioClip JumpSound;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    public void PlaySFX(AudioClip sfx)
    {
        audioSource.PlayOneShot(sfx);
    }
}
