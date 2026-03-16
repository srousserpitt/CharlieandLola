using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LolaInteract : MonoBehaviour
{
    public GameObject moonButton;
    public TextMeshProUGUI lolaDialogue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Make sure components are hidden by default
        if(moonButton != null)
        {
            moonButton.SetActive(false);
        }
        if (lolaDialogue != null)
        {
            lolaDialogue.enabled = false;
        }
    }

    // Triggers on player entry
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (moonButton != null && GameManager.Instance.levelsComplete() == 4)
            {
                moonButton.SetActive(true);
            }
            if (lolaDialogue != null)
            {
                //Debug.Log("Talk");
                lolaDialogue.text = GameManager.Instance.lolaDialogue();
                lolaDialogue.enabled = true;
            }
        }
    }

    // Triggers on player exit
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (moonButton != null)
            {
                moonButton.SetActive(false);
            }
            if(lolaDialogue != null)
            {
                lolaDialogue.enabled = false;
            }
        }
    }
}
