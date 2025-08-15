using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartSceneOnTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // só ativa com o Player
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}