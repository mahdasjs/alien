using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxSpawner : MonoBehaviour
{
    public GameObject box_prefab;


    public void SpawnBox()
    {
        GameObject box_Obj = Instantiate(box_prefab);
        Vector3 temp = transform.position;
        temp.z = 0f;
        box_Obj.transform.position = temp;
    }
}
