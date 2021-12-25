using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    [Range(0f, 0.5f)] public float moveAmount;
    public Vector3 currentPosition;

    private void Start()
    {
        currentPosition = this.gameObject.transform.position;
    }

    void Update()
    {
        currentPosition = this.gameObject.transform.position;

        if (Input.GetKey(KeyCode.D))
        {
            if(currentPosition.x< 12.71)
            {
                transform.position += new Vector3(moveAmount, 0, 0);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            if(-12.6 < currentPosition.x)
            {
                transform.position += new Vector3(-moveAmount, 0, 0);
            }
        }
    }
}