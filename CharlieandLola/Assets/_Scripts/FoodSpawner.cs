using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{

    public GameObject mushroom;
    public GameObject cabbage;
    public GameObject bananna;
    public GameObject goodFood;
    public float beginSpeed = 2.5f;
    public float dropSpeed = 4.0f;
    private float currentDropSpeed;
    //Total percent of 'bad' foods
    public float badRatio = 20;
    //Chance a new food will spawn this frame
    public float beginSpawnRate = 4;
    public float spawnRate = 15;
    private float currentSpawnRate;
    private float totalTime;
    private List<GameObject> foodCollection = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentSpawnRate = beginSpawnRate;
        currentDropSpeed = beginSpeed;
        totalTime = GameManager.Instance.timer;
        Debug.Log("Spawning");
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
        float type = Random.Range(0f, 100f);
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
                    //Food falls according to current drop speed
                    food.transform.Translate(Vector2.down * Time.deltaTime * currentDropSpeed);
                }
            }
            // Spawn new food
            if(Random.Range(0f,100f) < currentSpawnRate)
            {
                SpawnFood();
            }
            GameManager.Instance.timer -= Time.deltaTime;
            // Update rates
            currentDropSpeed = (dropSpeed - beginSpeed) * (totalTime - GameManager.Instance.timer) / totalTime + beginSpeed;
            currentSpawnRate = (spawnRate - beginSpawnRate) * (totalTime - GameManager.Instance.timer) / totalTime + beginSpawnRate;
        } else
        {
            GameManager.Instance.endLevel();
        }
    }
}
