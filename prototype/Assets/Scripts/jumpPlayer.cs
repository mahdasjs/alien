using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpPlayer : MonoBehaviour
{
    public float gravity;
    public Vector2 velocity;
    public float jumpVelocity = 50;
    public float groundHeghit = 1;
    public bool isGrounded = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isGrounded = false;
                velocity.y = jumpVelocity;
            }
        }
    }
    private void FixedUpdate()
    {
        Vector2 pos = transform.position;
        if (!isGrounded)
        {
            pos.y += velocity.y * Time.fixedDeltaTime;
            velocity.y += gravity * Time.fixedDeltaTime;
            if (pos.y <= groundHeghit)
            {
                pos.y = groundHeghit;
                isGrounded = true;
            }
        }

    }
}
