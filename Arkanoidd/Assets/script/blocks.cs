using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class blocks : MonoBehaviour
{
    int counter;
    public bool isred, ispink, isteal, isgreen;
    int numberOfHits;
    // Start is called before the first frame update
    void Start()
    {
        if (isred)
            numberOfHits = 3;
        if (isgreen)
            numberOfHits = 2;
        if (isteal)
            numberOfHits = 4;
        if (ispink)
            numberOfHits = 1;
    }
    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        counter++;
        if (counter == numberOfHits)
        {
            ball.instance.score++;
            Destroy(gameObject);
        }
    }
}