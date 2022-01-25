using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public bool platformWasTouched { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        platformWasTouched = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
