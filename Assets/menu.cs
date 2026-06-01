using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    [Header("Main Panel")]
    public GameObject menuPanel;
    public GameObject settingPanel;
    public GameObject materiPanel;
    public GameObject loadingPanel;

    [Header("Materi Panel")]
    public GameObject sejarahPanel;
    public GameObject peralatanPanel;
    public GameObject peraturanPanel;
    public GameObject nilaiBudayaPanel;

    void Start()
    {
        // Panel awal
        menuPanel.SetActive(true);
        materiPanel.SetActive(false);
        settingPanel.SetActive(false);
        loadingPanel.SetActive(false);
        // Materi awal
        sejarahPanel.SetActive(true);
        peralatanPanel.SetActive(false);
        peraturanPanel.SetActive(false);
        nilaiBudayaPanel.SetActive(false);
    }

    // START GAME
    public void startgame(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }


    // BUKA MATERI
    public void infoButton()
    {
        menuPanel.SetActive(false);
        materiPanel.SetActive(true);
    }


    public void settingButton()
    {
        menuPanel.SetActive(false);
        settingPanel.SetActive(true);
    }

    // KEMBALI KE MENU
    public void backButton()
    {
        menuPanel.SetActive(true);
        materiPanel.SetActive(false);
        settingPanel.SetActive(false);
    }

    // KELUAR GAME
    public void exitgame()
    {
        Application.Quit();
    }

    // AUDIO
    public void AudioButton()
    {
        AudioListener.pause = !AudioListener.pause;
    }

    // =========================
    // BUTTON MATERI
    // =========================

    public void ShowSejarah()
    {
        sejarahPanel.SetActive(true);
        peralatanPanel.SetActive(false);
        peraturanPanel.SetActive(false);
        nilaiBudayaPanel.SetActive(false);
    }

    public void ShowPeralatan()
    {
        sejarahPanel.SetActive(false);
        peralatanPanel.SetActive(true);
        peraturanPanel.SetActive(false);
        nilaiBudayaPanel.SetActive(false);
    }

    public void ShowPeraturan()
    {
        sejarahPanel.SetActive(false);
        peralatanPanel.SetActive(false);
        peraturanPanel.SetActive(true);
        nilaiBudayaPanel.SetActive(false);
    }

    public void ShowNilaiBudaya()
    {
        sejarahPanel.SetActive(false);
        peralatanPanel.SetActive(false);
        peraturanPanel.SetActive(false);
        nilaiBudayaPanel.SetActive(true);
    }

    public void nextButton()
    {
        if (sejarahPanel.activeSelf)
        {
            ShowPeralatan();
        }
        else if (peralatanPanel.activeSelf)
        {
            ShowPeraturan();
        }
        else if (peraturanPanel.activeSelf)
        {
            ShowNilaiBudaya();
        }
    }

    public void prevButton()
    {
        if (nilaiBudayaPanel.activeSelf)
        {
            ShowPeraturan();
        }
        else if (peraturanPanel.activeSelf)
        {
            ShowPeralatan();
        }
        else if (peralatanPanel.activeSelf)
        {
            ShowSejarah();
        }
    }
}