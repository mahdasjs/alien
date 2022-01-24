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
}
