using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHauinting : MonoBehaviour
{
    private Transform _playerTransform;
    [SerializeField] private NavMeshAgent _agent;
    private void Start()
    {
        _playerTransform = FindObjectOfType<PlayerMovement>().transform;
    }
    private void Update()
    {
        _agent.SetDestination(_playerTransform.position);
    }
}
