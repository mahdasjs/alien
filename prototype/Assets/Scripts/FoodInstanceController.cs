using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodInstanceController : MonoBehaviour
{
    public FoodItemConfig config;
    private Rigidbody2D rigidBody;
    public static bool foodLoss;

    private void Start()
    {
        // change mass based on config
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.mass = config.weight;

        foodLoss = false;
        // rotate randomly when instantiating
        transform.Rotate(0, Random.Range(-45, 45), 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Kill"))
        {
            Debug.Log("hi");
            foodLoss = true;
            Destroy(this.gameObject);
        }
    }
}
