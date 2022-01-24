using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlatformSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject PlatformPrefab;
    private Camera cam;
    private Vector3 camTopPoint;
    private float spawnRate = 4f;


    // Start is called before the first frame update
    void Start()
    {
        if (PlatformPrefab == null)
        {
            Debug.LogError("Platform Prefab connection is missing.");
            return;
        }

        cam = Camera.main;
        camTopPoint = cam.ViewportToWorldPoint(new Vector3(0.5f, 1f, cam.nearClipPlane));

        InvokeRepeating("SpawnPlatform", 1 / spawnRate, 1 / spawnRate);
    }


    void SpawnPlatform()
    {
        camTopPoint.x = Random.Range(-5f, 5f);
        camTopPoint.y += Random.Range(1f, 2.3f);
        GameObject _platform = Instantiate(PlatformPrefab, camTopPoint, Quaternion.identity);
        _platform.transform.SetParent(this.transform);

    }
}
