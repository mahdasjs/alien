using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private Collider2D col;
    [SerializeField]
    private float speed = 10f;
    [SerializeField]
    private float jumpForce = 10f;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    // Move player in horizontal axis with mouse
    void MovePlayer()
    {
        float _mouseAxisX = Input.GetAxis("Mouse X");
        float _moveX = speed * _mouseAxisX;

        transform.Translate(Vector3.right * _moveX * Time.deltaTime);
    }

    // Character jump when collide with platform
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Platform")
        {

            if (rb.velocity.y <= 0.1f)
            {

                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                //rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);

                Platform _platform = other.gameObject.GetComponent<Platform>();
                if (!_platform.platformWasTouched)
                {
                    _platform.platformWasTouched = true;
                    Player1.score += 1;
                }

            }
        }
    }
}
