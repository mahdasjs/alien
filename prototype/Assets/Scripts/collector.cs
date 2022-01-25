using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collector : MonoBehaviour
{

    private float width = 0f;

    void Awake()
    {
        width = GameObject.Find("BG").GetComponent<BoxCollider2D>().size.x;
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag=="bg"|| target.tag == "ground")
        {
            Debug.Log(width);
            Vector3 temp = target.transform.position;
            temp.x += width * 4;
            target.transform.position = temp;
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
