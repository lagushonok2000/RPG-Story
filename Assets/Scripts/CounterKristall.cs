using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CounterKristall : MonoBehaviour
{
    [SerializeField] private TMP_Text _redText;
    [SerializeField] private TMP_Text _blueText;
    [SerializeField] private TMP_Text _greenText;
    private int _counterGreen;
    private int _counterRed;
    private int _counterBlue;
    public void AddKristall(int ID)
    {
        if (ID==0)
        {
            _counterBlue++;
            Debug.Log("�����");
        }
        else if (ID==1)
        {
            _counterGreen++;
            Debug.Log("�������");
        }
        else if (ID==2)
        {
            _counterRed++;
            Debug.Log("�������");
        }
        UpdateText();
    }
    private void UpdateText()
    {
        _redText.text = "�������: " + _counterRed;
        _blueText.text = "�����: " + _counterBlue;
        _greenText.text = "�������: " + _counterGreen;
    }
}
