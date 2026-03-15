using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{

    public GameObject mushroom;
    public GameObject cabbage;
    public GameObject bananna;
    public float dropSpeed;
    private List<GameObject> foodCollection = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dropSpeed = 1f;
       // GameObject cabbagePrefab = Instantiate(cabbage, new Vector(0.2f, 0) Quaternion.identify);
    }

   // Vector2 GetDropPosition()
  //  {
      //  float x = Random.range(-8f, 8f);
       // float y = 4;
      //  return Vector2 (x, y);
   // }

    // Update is called once per frame
    void Update()
    {
     //   foreach (GameObject food in foodCollection)
        {
           // food.transform.Translate();
        }
    }
}
