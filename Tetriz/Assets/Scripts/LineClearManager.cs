using UnityEngine;
using TMPro;
using System.Collections;

public class LineClearManager : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] private TextMeshProUGUI clearText;
    [SerializeField] private float displayDuration = 1.5f;
    [SerializeField] private Animator textAnimator; // Optional: Animasyon eklemek isterseniz

    private void Awake()
    {
        if (clearText != null)
            clearText.gameObject.SetActive(false);
    }

    public void ShowClearText(int lineCount)
    {
        string message = GetClearMessage(lineCount);
        if (!string.IsNullOrEmpty(message))
        {
            StartCoroutine(DisplayTextCoroutine(message));
        }
    }

    private string GetClearMessage(int lineCount)
    {
        switch (lineCount)
        {
            case 1:
                return "SINGLE!";
            case 2:
                return "DOUBLE!!";
            case 3:
                return "TRIPLE!!!";
            case 4:
                return "TETRIS!!!!";
            default:
                return "";
        }
    }

    private IEnumerator DisplayTextCoroutine(string message)
    {
        clearText.text = message;
        clearText.gameObject.SetActive(true);

        if (textAnimator != null)
            textAnimator.SetTrigger("Show");

        yield return new WaitForSeconds(displayDuration);

        clearText.gameObject.SetActive(false);
    }
}