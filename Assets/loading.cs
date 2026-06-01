using UnityEngine;
using UnityEngine.SceneManagement;

public class loading
{
    public gameObject loadingPanel;
    void Start()
    {
        loadingPanel.SetActive(true);
    }
    public void startgame(string scenename)
    {
        SceneManager.LoadScene(scenename);
        while (!SceneManager.GetSceneByName(scenename).isLoaded)
        {
            // Tampilkan loading screen
            loadingPanel.SetActive(true);
        }
    }
}
