using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAPAudio : MonoBehaviour
{
    public AudioSource MusicSource;
    public AudioClip MusicClip;

    // Start is called before the first frame update
    void Start()
    {
        MusicSource.clip = MusicClip;
    }

    public void AP11Audio()
    {
        MusicSource.Play();
    }

    public void AP12Audio()
    {
        MusicSource.Play();
    }

    public void AP13Audio()
    {
        MusicSource.Play();
    }

    public void WatchAPVideo()
    {
        SceneManager.LoadScene("SceneAPVideo");
    }
}
