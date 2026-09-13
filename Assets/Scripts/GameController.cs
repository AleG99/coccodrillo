using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject Spawn;
    private int spawnInterval = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
            Application.Quit();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time % spawnInterval == 0) {
            GameObject.Instantiate(Spawn, new Vector3(10.0f, Random.Range(-4.5f, 1.5f), 0.0f), Quaternion.identity);
            spawnInterval = Random.Range(1, 5);
        }

    }
}
