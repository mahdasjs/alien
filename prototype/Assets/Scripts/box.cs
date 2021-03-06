using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class box : MonoBehaviour
{
    private float min_X = -5.5f, max_X = 5.5f;
    private bool canMove;
    private float move_speed = 2f;
    private Rigidbody2D myBody;
    private bool gameOver;
    private bool ignoreCollision;
    private bool ignoreTrigger;
    private Text scoreText;

    public GameObject restartMenuUI;



    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        myBody.gravityScale = 0f;

    }

    // Start is called before the first frame update
    void Start()
    {
        canMove = true;
        if (Random.Range(0, 2) > 0)
        {
            move_speed *= -1f;
        }
        gameController.instance.currentBox = this;
    }

    // Update is called once per frame
    void Update()
    {
        MoveBox();
    }

    void MoveBox()
    {
        if (canMove)
        {
            Vector3 temp = transform.position;
            temp.x += move_speed * Time.deltaTime;

            if (temp.x > max_X)
            {
                move_speed *= -1f;
            }
            else if (temp.x < min_X)
            {
                move_speed *= -1f;
            }
            transform.position = temp;
        }
    }
    public void DropBox()
    {
        canMove = false;
        myBody.gravityScale = Random.Range(2, 4);
    }

    void Landed()
    {
        if (gameOver)
            return;
        ignoreCollision = true;
        ignoreTrigger = true;

        boxSpawner.score++;
        boxSpawner.scoreText.text = boxSpawner.score.ToString();

        gameController.instance.SpawnNewBox();
        gameController.instance.MoveCamera();
    }

    void RestartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");

    }

    void OnCollisionEnter2D(Collision2D target)
    {
        if (ignoreCollision)
            return;
        if (target.gameObject.tag == "platform")
        {
            Invoke("Landed", 2f);
            ignoreCollision = true;

        }
        if (target.gameObject.tag == "box")
        {
            Invoke("Landed", 2f);
            ignoreCollision = true;

        }
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (ignoreTrigger)
            return;

        if (target.tag == "destroy")
        {
            CancelInvoke("Landed");
            gameOver = true;
            ignoreTrigger = true;

            Invoke("RestartGame",2f);
        }
    }
}
