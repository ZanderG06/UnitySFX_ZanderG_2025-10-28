using UnityEngine;

public class Trigger : MonoBehaviour
{
    public AudioSource loopingMusic;
    private bool paused;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        loopingMusic.UnPause();
        paused = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trigger"))
        {
            if (paused == false)
            {
                loopingMusic.Pause();
                paused = true;
            }
            else
            {
                loopingMusic.UnPause();
                paused = false;
            }
        }
    }
}
