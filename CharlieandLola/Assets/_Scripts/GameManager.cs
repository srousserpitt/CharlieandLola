using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System;

//Game manager for the DNID game
public class GameManager : MonoBehaviour
{
    //Singleton design
    public static GameManager Instance { get; private set; }

    //Managed variables forrunning the game
    [Header("Game State")]
    public int timer;
    public int score;
    public int level;
    //High scores and ending unlock
    private int levelOneScore = 0;
    private int levelTwoScore = 0;
    private int levelThreeScore = 0;
    private int levelFourScore = 0;
    public TextMeshProUGUI scoreText;
    public bool moonUnlocked = false;
    //Scene names
    public string livingRoomSceneName = "LivingRoom";
    public string kitchenSceneName = "Kitchen";
    public string fujiSceneName = "Fuji_Level";
    public string greenlandSceneName = "Greenland_Level";
    public string jupiterSceneName = "Jupiter_Level";
    public string seaSceneName = "Sea_Level";
    public string endingSceneName = "Moonmato";


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
        updateScoreText();
    }

    public void startLevel(int level)
    {
        score = 0;
        timer = 60;
        switch(level)
        {
            case 1:
                SceneManager.LoadScene(fujiSceneName);
                break;
            case 2:
                SceneManager.LoadScene(greenlandSceneName);
                break;
            case 3:
                SceneManager.LoadScene(jupiterSceneName);
                break;
            case 4:
                SceneManager.LoadScene(seaSceneName);
                break;
        }
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

    private void updateScoreText()
    {
        scoreText.text = "Level 1: " + levelOneScore + System.Environment.NewLine
            + "Level 2: " + levelTwoScore + System.Environment.NewLine
            + "Level 3: " + levelThreeScore + System.Environment.NewLine
            + "Level 4: " + levelFourScore;
    }

    private int levelsComplete()
    {
        int complete = 0;
        if (levelOneScore != 0)
        {
            complete++;
        }
        if (levelTwoScore != 0)
        {
            complete++;
        }
        if (levelThreeScore != 0)
        {
            complete++;
        }
        if (levelFourScore != 0)
        {
            complete++;
        }
        return complete;
    }

    public string lolaDialogue()
    {
        switch (levelsComplete())
        {
            case 0:
                return "I'm soooo hungry!";
            case 1:
                return "That doesn't look good...";
            case 2:
                return "That doesn't smell so bad";
            case 3:
                return "Just one more food!";
            case 4:
                return "I'm starving, let's eat!";
        }
        return "Oops, this is an error!";
    }
}
