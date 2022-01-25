using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    private Camera cam;
    private Vector3 camLowBound;
    public static int score = 0;
    public GameObject restartMenuUI;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        score = 0;

    }

    // Update is called once per frame
    void Update()
    {
        KillPlayer();
    }

    void KillPlayer()
    {
        camLowBound = cam.ViewportToWorldPoint(new Vector3(0f, 0f, cam.nearClipPlane));
        if (transform.position.y < camLowBound.y)
        {
            restartMenuUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
