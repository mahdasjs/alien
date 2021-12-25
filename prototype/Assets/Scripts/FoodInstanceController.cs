using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodInstanceController : MonoBehaviour
{
    public FoodItemConfig config;
    private Rigidbody rigidBody;
    public static bool foodLoss;

    private void Start()
    {
        // change mass based on config
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.mass = config.weight;

        foodLoss = false;
        // rotate randomly when instantiating
        transform.Rotate(0, Random.Range(-45, 45), 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Kill"))
        {
            foodLoss = true;
            Destroy(this.gameObject);
        }
    }
}
