using UnityEngine;

public class CheckTutorial : MonoBehaviour
{
    // the living room tutorial canvas
    public GameObject tutorialCanvas;

    //Makes sure the game manager exists and sets the canvas status
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

    // Flags the tutorial and closes the canvas
    public void finishTutorial()
    {
        GameManager.Instance.tutorialDone = true;
        tutorialCanvas.SetActive(false);
        Debug.Log("Finished");
    }
}
