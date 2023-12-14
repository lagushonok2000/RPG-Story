using UnityEngine;

public class NPCScale : MonoBehaviour
{
    [SerializeField] private RectTransform _point;
    [SerializeField] private float _scaleLength;
    [SerializeField] private int _scaleSectorsCount;
    [SerializeField] private int _currentRespect;
    [SerializeField] private float _widthPoint;
    private float[] _allXPositions;
    private int _constPlus;

    private void Awake()
    {
        _constPlus = _scaleSectorsCount / 2;
         _allXPositions = new float[_scaleSectorsCount + 1];
        _allXPositions[0] = _scaleLength / 2 * (-1) + (_widthPoint / 2);
       
        for (int i = 0; i < _scaleSectorsCount; i++)
        {
            _allXPositions[i + 1] = _allXPositions[i] + _scaleLength / _scaleSectorsCount;
        }
        _allXPositions[_scaleSectorsCount] -= _widthPoint;
    }

    private void Start()
    {
        _point.anchoredPosition = new Vector2(_allXPositions[_currentRespect + _constPlus], _point.anchoredPosition.y);
    }
}