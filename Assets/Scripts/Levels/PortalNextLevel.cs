using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalNextLevel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(0);
    }
}