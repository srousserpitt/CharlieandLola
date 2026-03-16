using UnityEngine;

public class StartLevel : MonoBehaviour
{
    public GameObject infoCanvas;
    public GameObject levelUICanvas;
    public GameObject levelSpawner;
    public int levelNumber;
    
    // Passes stuff to the game manager since the singleton is just moving around, not instantiating a new one each level
    public void onReady()
    {
        infoCanvas.SetActive(false);
        GameManager.Instance.startLevel(levelNumber, levelUICanvas, levelSpawner);
    }


}
