using UnityEngine;

public class StartScenePositions : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private GameObject[] _nPC;

    private void Start()
    {
        var random = new System.Random();
        for (int i = _spawnPoints.Length - 1; i >= 1; i--)
        {
            int j = random.Next(i + 1);
            var temp = _spawnPoints[j];

            _spawnPoints[j] = _spawnPoints[i];
            _spawnPoints[i] = temp;
        }

        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            _nPC[i].transform.position = _spawnPoints[i].position;
        }
    }
}