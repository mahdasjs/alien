using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    private Camera cam;


    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 _camFarRightPoint = cam.ViewportToWorldPoint(new Vector3(1, 1, cam.nearClipPlane));

        // if (transform.position.y + cam.orthographicSize >= _camFarRightPoint.y)
        // {
        //     cam.transform.Translate(transform.up * cam.orthographicSize * Time.deltaTime);

        // }

        if (transform.position.y > cam.transform.position.y)
        {

            cam.transform.position = new Vector3(cam.transform.position.x, transform.position.y, cam.transform.position.z);

        }

    }


}
