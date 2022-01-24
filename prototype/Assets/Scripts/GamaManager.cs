using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamaManager : MonoBehaviour
{
    public GameObject selectedskin;
    public GameObject Player;

    private Sprite playersprite;


    // Start is called before the first frame update
    void Start()
    {
        playersprite = selectedskin.GetComponent<SpriteRenderer>().sprite;
        Player.GetComponent<SpriteRenderer>().sprite = playersprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
