using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public Canvas Main;
    public Canvas Options;



    // Start is called before the first frame update
    void Start()
    {
        Main.enabled = true;
        Options.enabled = false;
    }

    public void OnPlay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void OnOptions()
    {
        Main.enabled = false;
        Options.enabled = true;

    }
    public void OnExit()
    {
        Application.Quit();
    }
    public void OnBackToMain()
    {
        Main.enabled = true;
        Options.enabled = false;
    }

}
