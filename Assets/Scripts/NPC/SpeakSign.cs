using UnityEngine;

public class SpeakSign : MonoBehaviour
{
    [SerializeField] private GameObject _canvas;
    [SerializeField] private GameObject _dialogCanvas;
    private bool _enter;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return) && _enter)
        {
          _dialogCanvas.SetActive(true);
          Time.timeScale = 0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _canvas.SetActive(true);
        _enter = true;
    }

    private void OnTriggerExit(Collider other)
    {
        _canvas.SetActive(false);
        _enter = false;
    }
}