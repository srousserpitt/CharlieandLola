using UnityEngine;

public class CheckTutorial : MonoBehaviour
{
    public GameObject tutorialCanvas;

    private void Awake()
    {
        if (GameManager.Instance != null)
        {
            Debug.Log("Manager Exists");
            if (GameManager.Instance.tutorialDone != true)
            {
                tutorialCanvas.SetActive(true);
                Debug.Log("Tutorial active");
            } else
            {
                tutorialCanvas.SetActive(false);
            }
        }
    }
    public void finishTutorial()
    {
        GameManager.Instance.tutorialDone = true;
        tutorialCanvas.SetActive(false);
        Debug.Log("Finished");
    }
}
