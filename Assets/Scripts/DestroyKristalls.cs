using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyKristalls : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Destroy(gameObject);
    }
}
