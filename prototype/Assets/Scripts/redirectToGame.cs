using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class redirectToGame : MonoBehaviour
{

    // Start is called before the first frame update

    public void onclick()
    {
        SceneManager.LoadScene("menu");

    }
}
