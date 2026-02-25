using UnityEngine;
using UnityEngine.SceneManagement;


//Game manager for the DNID game
public class GameManager : MonoBehaviour
{
    //Singleton design
    public static GameManager Instance { get; private set; }

    //Managed variables forrunning the game
    [Header("Game State")]
    public int score;
    public int level;
    //High scores and ending unlock
    private int levelOneScore;
    private int levelTwoScore;
    private int levelThreeScore;
    private int levelFourScore;
    private bool moonUnlocked;
    //Scene names
    public string livingRoomSceneName = "LivingRoom";
    public string kitchenSceneName = "Kitchen";
    public string fujiSceneName = "Fuji_Level";
    public string greenlandSceneName = "Greenland_Level";
    public string jupiterSceneName = "Jupiter_Level";
    public string seaSceneName = "Sea_Level";
    public string endingSceneName = "Moonmato";


    //access
    public static GameManager getInstance()
    {
        if (Instance == null)
        {
            Instance = new GameManager();
        }
        return Instance;
    }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            //If another game object exists, destroy this one
            Destroy(gameObject);
            return;
        }

        //If not, set the instance here and persist across scenes
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void addScore(int Amount)
    {
        score += Amount;
        Debug.Log($"Score: {score}");
        //Update UI
    }

    public void endLevel(int Level)
    {
        //update high scores
        switch (Level)
        {
            case 1:
                if (score > levelOneScore)
                {
                    levelOneScore = score;
                }
                break;
            case 2:
                if (score > levelTwoScore)
                {
                    levelTwoScore = score;
                }
                break;
            case 3:
                if (score > levelThreeScore)
                {
                    levelThreeScore = score;
                }
                break;
            case 4:
                if (score > levelFourScore)
                {
                    levelFourScore = score;
                }
                break;
        }
        //Reset score
        score = 0;
        //Check if end unlocked
        if (levelOneScore != 0 && levelTwoScore != 0 && levelThreeScore != 0 && levelFourScore != 0)
        {
            moonUnlocked = true;
        }
        //Return to living room
        if (!string.IsNullOrEmpty(livingRoomSceneName))
        {
            SceneManager.LoadScene(livingRoomSceneName);
        } else
        {
            Debug.Log("FIX LIVING ROOM SCENE NAME!!!");
        }
    }
}
