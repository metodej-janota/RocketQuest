using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class volumeControll : MonoBehaviour
{
    [SerializeField] private Slider volumeSliderMusic = null;
    
    public GameObject menu;

    private bool isMenuOpen = false;

    private void Start()
    {
		Time.timeScale = 1;
        LoadValues();
        if (menu != null)
        {
            menu.SetActive(false);
            isMenuOpen = false;
        }
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isMenuOpen)
            {
                OpenMenu();
            }
            else
            {
                CloseMenu();
            }
        }
    }
    
    void OpenMenu()
    {
        if (menu != null)
        {
            menu.SetActive(true);
            isMenuOpen = true;
            Time.timeScale = 0f;
        }
    }

    void CloseMenu()
    {
        if (menu != null)
        {
            menu.SetActive(false);
            isMenuOpen = false;
            Time.timeScale = 1f;
        }
    }

    public void SaveVolumeButton()
    {
        float volumeValue = volumeSliderMusic.value;
        PlayerPrefs.SetFloat("VolumeValue", volumeValue);
        LoadValues();
    }

    void LoadValues()
    {
        float volumeValue = PlayerPrefs.GetFloat("VolumeValue");
        volumeSliderMusic.value = volumeValue;
        AudioListener.volume = volumeValue;
    }
    
    public void exit()
    {
        Application.Quit();
    }
    
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
