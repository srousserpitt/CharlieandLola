using UnityEngine;
using UnityEngine.UI;

public class ButtonDisplay : MonoBehaviour
{

    public GameObject hiddenButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (hiddenButton != null)
        {
            hiddenButton.SetActive(false);
        }
    }

    // Triggers on player entry
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if(hiddenButton != null)
            {
                hiddenButton.SetActive(true);
            }
        }
    }

    // Triggers on player exit
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (hiddenButton != null)
            {
                hiddenButton.SetActive(false);
            }
        }
    }
}
