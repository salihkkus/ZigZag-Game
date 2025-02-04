using UnityEngine;
using UnityEngine.UI;
using TMPro; // Eğer TMP kullanıyorsan ekle
using System.Collections;

public class GameManager : MonoBehaviour
{
    public GameObject startButton; // Başlat Butonu
    public TextMeshProUGUI companyNameTMP; // TMP Kullanıyorsan

    void Start()
    {
        Time.timeScale = 0; // Oyunu durdur
    }

    public void StartGame()
    {
        Time.timeScale = 1; // Oyunu başlat
        startButton.SetActive(false); // Butonu gizle
        StartCoroutine(FadeOutCompanyName()); // Şirket adını animasyonlu gizle
    }

    IEnumerator FadeOutCompanyName()
    {
        float duration = 5f; // 1 saniyede kaybolsun
        float elapsedTime = 0f;


        // TMP bileşeni varsa
        if (companyNameTMP != null)
        {
            Color startColor = companyNameTMP.color;
            while (elapsedTime < duration)
            {
                elapsedTime += Time.deltaTime;
                float alpha = Mathf.Lerp(1, 0, elapsedTime / duration);
                companyNameTMP.color = new Color(startColor.r, startColor.g, startColor.b, alpha);
                yield return null;
            }
            companyNameTMP.gameObject.SetActive(false);
        }
    }
}
