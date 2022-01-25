﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{
    public static gameController instance;

    public boxSpawner box_spawner;

    [HideInInspector]
    public box currentBox;

    public cameraFollow cameraScript;
    private int moveCount;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        box_spawner.SpawnBox();
        
    }

    // Update is called once per frame
    void Update()
    {
        DetectInput();
    }

    void DetectInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentBox.DropBox();
        }
    }

    public void SpawnNewBox()
    {
        Invoke("NewBox", 2f);
    }

    void NewBox()
    {
        box_spawner.SpawnBox();
    }

    public void MoveCamera()
    {
        moveCount++;
        if (moveCount == 3)
        {
            moveCount = 0;
            //cameraScript.targetPos.y += 2f;
        }
    }

    public void RestartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(
            UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}

