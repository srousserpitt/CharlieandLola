using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Singleton design
    public static GameManager Instance { get; private set; }

    [Header("Game State")]
    public int score;
    public int level;
    private int levelOneScore;
    private int levelTwoScore;
    private int levelThreeScore;
    private int levelFourScore;
    private bool moonUnlocked;


    //access
    public static GameManager getInstance()
    {
    if(Instance == null)
    {
        Instance = new GameManager();
    }
    return Instance;
    }
    
    private void Awake()
    {
        if(Instance == null)
        {
            //COPY STUFF FROM DEMO GH
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore(int Amount)
    {

    }

    public void endLevel(int Level)
    {
        //Return to living room, update high scores
    }
}
