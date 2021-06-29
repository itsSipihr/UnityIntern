using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuActivation : MonoBehaviour
{
    public Button menuButton;
    public Button pauseButton;
    public Button settingsButton;
    public Button creditsButton;
    public Button shopButton;
    public Image menuPanel;

    public TextMeshProUGUI pauseButtonText;

    bool isPauseClicked = false;

    public void OpenMenuPanel()
    {
        menuPanel.gameObject.SetActive(true);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

}
