using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoadingBar : MonoBehaviour
{
    public Image fillBar;
    public GameObject loadingPanel;
    public GameObject homePanel;

    void Start()
    {
        fillBar.fillAmount = 0;
        homePanel.SetActive(false);
        StartCoroutine(Loading());
    }

    IEnumerator Loading()
    {
        float progress = 0;

        while (progress < 1)
        {
            progress += Time.deltaTime / 3f;
            fillBar.fillAmount = progress;
            yield return null;
        }

        yield return new WaitForSeconds(1f);

        loadingPanel.SetActive(false);
        homePanel.SetActive(true);
    }
}
