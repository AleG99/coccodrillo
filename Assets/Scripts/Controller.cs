using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{
    public float upSpeed = 6;
    public float downSpeed = 4;
    private int score = 0;

    public TextMeshProUGUI scoreText;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return) && transform.position.y >= -5.0)
        {
            transform.position += Vector3.down * downSpeed * Time.deltaTime;
        } else if (transform.position.y <= 2)
        {
            transform.position += Vector3.up * upSpeed * Time.deltaTime;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(col.gameObject);
        score++;
        scoreText.SetText($"{score}");
    }
}
