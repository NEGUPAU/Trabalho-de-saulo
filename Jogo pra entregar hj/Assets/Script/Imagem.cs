using UnityEngine;
using UnityEngine.UI;

public class MostrarImagem : MonoBehaviour
{
    public Image imagemVitoria; // arraste a imagem aqui
    public AudioSource somVitoria; // arraste o AudioSource aqui

    void Start()
    {
        imagemVitoria.enabled = false; // imagem começa invisível
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            imagemVitoria.enabled = true; // mostra a imagem
            somVitoria.Play(); // toca o som
        }
    }
}