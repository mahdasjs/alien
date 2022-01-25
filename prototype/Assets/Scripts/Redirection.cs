using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Redirection : MonoBehaviour
{


    public void foodClick()
    {
        SceneManager.LoadScene("food");

    }
    public void hillClick()
    {
        SceneManager.LoadScene("Sample");

    }
    public void towerClick()
    {
        SceneManager.LoadScene("tower");

    }
    public void runnerClick()
    {
        SceneManager.LoadScene("runner");
    }
    public void doodleClick()
    {
        SceneManager.LoadScene("MainScene");

    }
    public void changeChar()
    {
        SceneManager.LoadScene("menu");

    }
}
