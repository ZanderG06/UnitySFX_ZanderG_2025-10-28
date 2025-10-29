using UnityEngine;

public class Trigger : MonoBehaviour
{
    public AudioSource loopingMusic;
    public AudioSource sounds;
    public AudioClip music;
    public AudioClip pickup1;
    public AudioClip pickup2;
    private bool paused;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        loopingMusic.clip = music;
        loopingMusic.Play();
        paused = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trigger"))
        {
            if (paused == false)
            {
                paused = true;
                loopingMusic.Pause();
            }
            else
            {
                paused = false;
                loopingMusic.UnPause();
            }
        }

        if (other.CompareTag("Pickup1"))
        {
            sounds.clip = pickup1;
            sounds.Play();
        }

        if (other.CompareTag("Pickup2"))
        {
            sounds.clip = pickup2;
            sounds.Play();
        }
    }
}
