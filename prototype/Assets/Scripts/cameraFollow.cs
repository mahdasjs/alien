using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    [HideInInspector]
    public Vector3 targetPos;

    private float smoothMove = 1f;

    void Start()
    {
        targetPos = transform.position;
    }
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetPos, smoothMove * Time.deltaTime);
        
    }
}
