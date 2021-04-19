using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ball : MonoBehaviour
{
    public  Text scoreText;
    public int score;
    public float speed = 100.0f;
    public static ball instance;
    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketWidth)
    {
        return (ballPos.x - racketPos.x) / racketWidth;
    }    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
    }
    private void Update()
    {
        scoreText.text = score.ToString();
    }
    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "racket")
        {
            float x = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.x);
            Vector2 dir = new Vector2(x, 1).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
        if (col.gameObject.tag == "square")
        {
            scoreText.text = score.ToString();
        }
    }
}
