using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject player;
    public GameObject platformPrefab;
    public GameObject myPlat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void onTriggerEnter2D(Collider2D collision)
    {
        myPlat = (GameObject)Instantiate(platformPrefab, new Vector2(Random.Range(-5.5f , 5.5f),player.transform.position.y + (14 * Random.Range(0.5f , 1f))),Quaternion.identity);
        Destroy(collision.gameObject);
    }
}
