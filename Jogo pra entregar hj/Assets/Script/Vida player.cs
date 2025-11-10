using UnityEngine;
using UnityEngine.UI;

public class PlayerVida : MonoBehaviour
{
    public int vidaMaxima = 3;
    public int vidaAtual;

    public Image[] coracoes; // arrasta as imagens dos corações aqui no Inspector
    public Sprite coracaoCheio;
    public Sprite coracaoVazio;

    private bool invencivel = false;
    public float tempoInvencivel = 1f;

    void Start()
    {
        vidaAtual = vidaMaxima;
        AtualizarCoracoes();
    }

    public void TomarDano(int dano)
    {
        if (invencivel) return;

        vidaAtual -= dano;
        if (vidaAtual < 0) vidaAtual = 0;

        AtualizarCoracoes();

        // Efeito de invencibilidade curta
        StartCoroutine(Invencivel());
        
        Debug.Log("Player tomou dano! Vida: " + vidaAtual);

        if (vidaAtual <= 0)
        {
            Debug.Log("Jogador morreu!");
            // Aqui tu pode reiniciar a cena ou chamar animação de morte
        }
    }

    void AtualizarCoracoes()
    {
        for (int i = 0; i < coracoes.Length; i++)
        {
            if (i < vidaAtual)
                coracoes[i].sprite = coracaoCheio;
            else
                coracoes[i].sprite = coracaoVazio;
        }
    }

    System.Collections.IEnumerator Invencivel()
    {
        invencivel = true;
        yield return new WaitForSeconds(tempoInvencivel);
        invencivel = false;
    }
}
