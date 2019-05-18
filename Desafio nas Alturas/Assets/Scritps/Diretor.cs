﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    public GameObject imagemGameOver;
    [SerializeField]

    private Aviao aviao;

    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        imagemGameOver.SetActive(true);
        Debug.Log("Acabou");
    }

    void Start()
        {
            aviao = GameObject.FindObjectOfType<Aviao>();
        }

    public void ReiniciarJogo()
    {
        aviao.Reiniciar();
        imagemGameOver.SetActive(false);
        Time.timeScale = 1;
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

