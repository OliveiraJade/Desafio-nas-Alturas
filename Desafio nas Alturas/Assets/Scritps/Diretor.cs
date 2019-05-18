using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    public GameObject imagemGameOver;
    [SerializeField]

    private Aviao aviao;

    private Pontuacao pontuacao;

 
    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        imagemGameOver.SetActive(true);
        Debug.Log("Acabou");
    }

    void Start()
        {
            aviao = GameObject.FindObjectOfType<Aviao>();
            pontuacao = GameObject.FindObjectOfType<Pontuacao>();
        
        }

    public void ReiniciarJogo()
    {
        aviao.Reiniciar();
        imagemGameOver.SetActive(false);
        Time.timeScale = 1;
        pontuacao.Reiniciar();
        DestruirObstaculos();
        Debug.Log("Reiniciou");
    }

    private void DestruirObstaculos()
    {
        Obstaculo[] obstaculosEncontrados =  GameObject.FindObjectsOfType<Obstaculo>();
        foreach(Obstaculo obstaculoAtual in obstaculosEncontrados)
        {
            obstaculoAtual.Destruir();
        }
    }
  }

