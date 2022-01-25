using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class boxSpawner : MonoBehaviour
{
    public GameObject box_prefab;

    public static Text scoreText;
    public static int score = 0;

    void Awake()
    {
        scoreText = GameObject.Find("score").GetComponent<Text>();
        scoreText.text = "0";
    }

    public void SpawnBox()
    {
        GameObject box_Obj = Instantiate(box_prefab);
        Vector3 temp = transform.position;
        temp.z = 0f;
        box_Obj.transform.position = temp;
    }
}
