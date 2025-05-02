using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource MusicSource;
    
    public AudioClip backgroundMusic;

    private void Start()
    {
        MusicSource.clip = backgroundMusic;
        MusicSource.Play();
        
    } // Start
    
}// AudioManager
