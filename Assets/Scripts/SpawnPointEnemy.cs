using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class SpawnPointEnemy : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPointsEnemy;
    [SerializeField] private float _timeSpawn;
    [SerializeField] private GameObject _prefabEnemy;
    private bool _isSpawning;

    private void Start()
    {
        _isSpawning = true;
        StartCoroutine(Spawner());
    }
    private void Spawn()
    {
        var random = Random.Range(0,_spawnPointsEnemy.Length);
        var enemy = Instantiate(_prefabEnemy);
        Debug.Log(_spawnPointsEnemy.Length);
        enemy.transform.position = _spawnPointsEnemy[random].position;
    }

    private IEnumerator Spawner()
    {
        while(_isSpawning )
        {
            yield return new WaitForSeconds(_timeSpawn);
            Spawn();
        } 
    }
}