using UnityEngine;

public class TestAudio : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        Invoke("PlaySound", 2f);
    }

    void PlaySound()
    {
        audioSource.Play();
        Debug.Log("Audio should be playing");
    }
}
