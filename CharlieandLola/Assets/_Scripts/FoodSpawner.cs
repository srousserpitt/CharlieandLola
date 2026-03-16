using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{

    public GameObject mushroom;
    public GameObject cabbage;
    public GameObject bananna;
    public GameObject goodFood;
    public float dropSpeed;
    //Total percent of 'bad' foods
    public float badRatio;
    private List<GameObject> foodCollection = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < Random.Range(2, 7); i++)
        {
            SpawnFood();
        }
    }

    void SpawnFood()
    {
        GameObject newFood = Instantiate(GetRandomType(), GetDropPosition(), Quaternion.identity);
        foodCollection.Add(newFood);
    }

    Vector2 GetDropPosition()
    {
        float x = Random.Range(-8f, 8f);
        float y = 4f;
        return new Vector2(x, y);
    }

    GameObject GetRandomType()
    {
        float type = Random.Range(0f, badRatio);
        if (type < badRatio / 3)
        {
            return mushroom;
        }
        else if (type < badRatio * 2 / 3)
        {
            return cabbage;
        }
        else if (type < badRatio)
        {
            return bananna;
        }
        else
        {
            return goodFood;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.timer > 0)
        {
            foreach (GameObject food in foodCollection)
            {
                if (food != null)
                {
                    //Food falls according to dropspeed, update to change
                    food.transform.Translate(Vector2.down * Time.deltaTime * dropSpeed);
                }
            }
            GameManager.Instance.timer -= Time.deltaTime;
        } else
        {
            GameManager.Instance.endLevel();
        }
    }
}
