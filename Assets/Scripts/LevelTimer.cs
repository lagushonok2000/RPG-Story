using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelTimer : MonoBehaviour
{
    [SerializeField] private  TMP_Text _timerText;
    [SerializeField] private float[] _levelsTime;
    [SerializeField] private GameObject _victory;
    [SerializeField] private GameObject _defeat;
    [SerializeField] private CounterKristall _countKristall;
    private bool _stopTimer;


    private void Start()
    {
        StartCoroutine(Timer());
    }
    private IEnumerator Timer()
    {
        int _smoothness;
        float currentTime = _levelsTime[CurrentLevels.Level];

        _smoothness = 1;

        while (currentTime > 0)
        {
            _timerText.text = currentTime.ToString();
            currentTime -= _smoothness;
            yield return new WaitForSeconds (_smoothness);
        }

        _timerText.text = "Время вышло";
        Time.timeScale = 0;

        if (_countKristall.CounterBlue >= 30 || _countKristall.CounterGreen >= 30 || _countKristall.CounterRed >= 30)
        {
            _victory.SetActive(true);
            CurrentLevels.Level++;
        }
        else
        {
            _defeat.SetActive(true);
        }
    }
}
