using UnityEngine;

public class DelayedAudioPlay : MonoBehaviour
{
    public float delayInSeconds; // Ganti dengan jumlah detik yang diinginkan
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void PlayDelayedSound()
    {
        audioSource.Play();
    }

    private void Play()
    {
        Invoke("PlayDelayedSound", delayInSeconds);
    }
}
