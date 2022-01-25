using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeadScript : MonoBehaviour
{
    public GameObject restartMenuUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Ground")
        {
            restartMenuUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }

}
