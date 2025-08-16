using System;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class onCollision : MonoBehaviour
{
    // public score score;
    score scorescript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scorescript = GetComponent<score>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject, 1);
        if (collision.gameObject.tag == this.gameObject.tag)
        {
            Debug.Log("working");
            this.gameObject.GetComponent<Renderer>().material.color = Color.green;
            scorescript.addScore(1);

        }
        else
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.red;
            scorescript.addScore(-1);
        }
    }

}
