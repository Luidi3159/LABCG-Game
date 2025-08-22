using UnityEngine;
using TMPro;

public class PontosManager : MonoBehaviour
{
    public TextMeshProUGUI textoPontos;
    private int pontos;

    void Start()
    {
        // Carrega os pontos salvos
        //pontos = PlayerPrefs.GetInt("Pontos", 0);
        pontos=0;
        AtualizarTexto();
    }

    public void AdicionarPonto()
    {
        pontos++;
        PlayerPrefs.SetInt("Pontos", pontos); // Salva os pontos
        AtualizarTexto();
    }

    void AtualizarTexto()
    {
        textoPontos.text = "Pontos: " + pontos.ToString();
    }
}
