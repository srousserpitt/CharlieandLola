using UnityEngine;
using TMPro;

public class UpdateUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText.text = "Score: " + GameManager.Instance.score.ToString("n0");
        timerText.text = "Time: " + GameManager.Instance.timer.ToString("0.00");
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + GameManager.Instance.score.ToString("n0");
        timerText.text = "Time: " + GameManager.Instance.timer.ToString("0.00");
    }
}
