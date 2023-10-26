using UnityEngine;

public class KristallGenerator : MonoBehaviour
{
    [SerializeField] private KristallsGroup[] _kristallsGroup;
    [SerializeField] private Material[] _kristallMaterials;
    [SerializeField] private Kristall _prefab;
    [SerializeField] private int _countGroup;
    [SerializeField] private int _countKristallInGroupMin;
    [SerializeField] private int _countKristallInGroupMax;
    private int _currentCountGroup;

    private void Start()
    {
        SpawnGroup();
    }

    private void SpawnKristalls()
    {
        int indexGroup = Random.Range(0, _kristallsGroup.Length);

        while (!_kristallsGroup[indexGroup].IsFree) // проверка занята ли группа
        {
            indexGroup = Random.Range(0, _kristallsGroup.Length);
        }

        _kristallsGroup[indexGroup].IsFree = false;

        int indexMaterial = Random.Range(0, _kristallMaterials.Length);
        int countKristalls = Random.Range(_countKristallInGroupMin, _countKristallInGroupMax);
        int currentCountKristalls = 0;

        while (currentCountKristalls < countKristalls)
        {
            int indexSpawnPoint = Random.Range(0, _kristallsGroup[indexGroup].SpawnPoints.Length);

            while (!_kristallsGroup[indexGroup].SpawnPoints[indexSpawnPoint].IsFree)
            {
                indexSpawnPoint = Random.Range(0, _kristallsGroup[indexGroup].SpawnPoints.Length);
            }

            _kristallsGroup[indexGroup].SpawnPoints[indexSpawnPoint].IsFree = false;

            Kristall kristall = GameObject.Instantiate(_prefab);
            kristall.transform.position = _kristallsGroup[indexGroup].SpawnPoints[indexSpawnPoint].transform.position;
            kristall.KristallMeshRenderer.material = _kristallMaterials[indexMaterial];
            kristall.ID = indexMaterial;
            currentCountKristalls++;
        }

    }

    private void SpawnGroup()
    {
        int countGroup = 0;

        while(countGroup < _countGroup)
        {
            SpawnKristalls();
            countGroup++;
        }
    }
}
