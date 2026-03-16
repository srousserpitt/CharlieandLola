using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadFoodController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // nothing, we don't do anything special on object creation
    }

    // Update is called once per frame
    void Update()
    {
        //Delete if object hits the floor (or goes way below the floor, not checking)
        if (gameObject.transform.position.y <= -20f)
        {
            Destroy(gameObject);
        }
    }

    // What happens when the player collides with the food
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Debug.Log("Collided with bad food");
            Destroy(gameObject);
            GameManager.Instance.addScore(-10);
        }
    }
}