using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Redirection : MonoBehaviour
{

    // Start is called before the first frame update

    public void foodClick()
    {
        SceneManager.LoadScene("food");

    }
    public void hillClick()
    {
        SceneManager.LoadScene("hill");

    }
    public void towerClick()
    {
        SceneManager.LoadScene("tower");

    }
    public void runnerClick()
    {
        SceneManager.LoadScene("runner");

    }
    public void changeChar()
    {
        SceneManager.LoadScene("menu");

    }
}
