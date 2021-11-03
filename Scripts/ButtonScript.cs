using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   public void StartARCamera()
    {
        SceneManager.LoadScene("SceneSelection");
    }

    public void ExitApp()
    {
        Application.Quit();
    }

    public void WatchVideo()
    {
        SceneManager.LoadScene("SceneAPVideo");
    }

    public void PlayFE()
    {
        SceneManager.LoadScene("ScenePlayFE");
    }

}
