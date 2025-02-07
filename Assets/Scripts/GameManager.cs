using UnityEngine;
using UnityEngine.UI;
using TMPro; // Add this if using TextMeshPro
using System.Collections;

public class GameManager : MonoBehaviour
{
    public GameObject startButton; // Start Button
    public TextMeshProUGUI companyNameTMP; // Company name (TextMeshPro component)

    void Start()
    {
        Time.timeScale = 0; // Pause the game at the start
    }

    public void StartGame()
    {
        Time.timeScale = 1; // Resume the game
        startButton.SetActive(false); // Hide the start button after clicking
        StartCoroutine(FadeOutCompanyName()); // Start fading out the company name
    }

    IEnumerator FadeOutCompanyName()
    {
        float duration = 5f; // Duration for fading out (5 seconds)
        float elapsedTime = 0f;

        // Check if the TextMeshPro component is assigned
        if (companyNameTMP != null)
        {
            Color startColor = companyNameTMP.color; // Get the initial color
            while (elapsedTime < duration)
            {
                elapsedTime += Time.deltaTime;
                float alpha = Mathf.Lerp(1, 0, elapsedTime / duration); // Gradually decrease the alpha
                companyNameTMP.color = new Color(startColor.r, startColor.g, startColor.b, alpha);
                yield return null; // Wait for the next frame
            }
            companyNameTMP.gameObject.SetActive(false); // Disable the text object after fading
        }
    }
}
