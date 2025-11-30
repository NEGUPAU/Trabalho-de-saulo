using UnityEngine;

public class MensagemTrigger : MonoBehaviour
{
    public GameObject mensagemUI;

    void Start()
    {
        mensagemUI.SetActive(false); // Mensagem começa invisível
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            mensagemUI.SetActive(true); // Mostra a mensagem
        }
    }
}