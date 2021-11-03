using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class VirtualButtonAP : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject virtualButton;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "AP")
        {
            SceneManager.LoadScene("SceneAP");
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
       
    }

    // Start is called before the first frame update
    void Start()
    {
        virtualButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

}
