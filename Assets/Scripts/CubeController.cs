using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private float speed = -12;
    private float deadLine = -10;

    void Update()
    {
        transform.Translate(this.speed * Time.deltaTime, 0, 0);
        if(transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    //課題追加
    void OnCollisionEnter2D(Collision2D collider)
    {
        if(collider.gameObject.tag == "CubeTag" || collider.gameObject.tag == "GroundTag")
        {
            GetComponent<AudioSource>().Play();
        }
        else if(collider.gameObject.tag == "CubeTag")
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
