using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodFoodController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Delete if object hits floor
        if(gameObject.transform.position.y <= -20f)
        {
            Destroy(gameObject);
        }
    }
    
    // What happens when the player collides with the food
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //Debug.Log("Collided with good food");
            Destroy(gameObject);
            GameManager.Instance.addScore(10);
        }
    }
}
