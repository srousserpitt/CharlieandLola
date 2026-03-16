using UnityEngine;

public class StartLevel : MonoBehaviour
{
    public GameObject infoCanvas;
    public GameObject levelUICanvas;
    public int levelNumber;
    
    public void onReady()
    {
        infoCanvas.SetActive(false);
        GameManager.Instance.startLevel(levelNumber, levelUICanvas);
    }


}
