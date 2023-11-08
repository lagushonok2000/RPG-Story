using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GamePause : MonoBehaviour
{
    [SerializeField] private Button _pauseButton;
    [SerializeField] private Button _stopPauseButton;
    [SerializeField] private GameObject _pausePanel;
    private void Start()
    {
        _pauseButton.onClick.AddListener(PauseButton);
        _stopPauseButton.onClick.AddListener(StopPauseButton);
    }

    public void PauseButton()
    {
        Time.timeScale = 0;
        _pausePanel.SetActive(true);
    }

    public void StopPauseButton() 
    {
        Time.timeScale = 1.0f;
        _pausePanel.SetActive(false);
    }

}
