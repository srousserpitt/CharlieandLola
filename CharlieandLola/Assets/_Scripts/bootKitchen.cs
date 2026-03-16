using UnityEngine;
using TMPro;

public class bootKitchen : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager.Instance.scoreText = scoreText;
        Debug.Log("text set");
        GameManager.Instance.updateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
