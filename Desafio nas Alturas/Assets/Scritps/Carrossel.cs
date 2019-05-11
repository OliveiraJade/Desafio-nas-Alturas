using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrossel : MonoBehaviour
{
    [SerializeField]

    private float velocidade;

    private Vector3 posicaoInicial;

    private float tamanhoRealDaImagem;

    private void Awake()
    {
        posicaoInicial = transform.localPosition;
        float tamanhoDaImagem = GetComponent<SpriteRenderer>().size.x;
        float escala = transform.localScale.x;
        tamanhoRealDaImagem = tamanhoDaImagem * escala;
        Debug.Log(tamanhoRealDaImagem);
    }
    // Update is called once per frame
    void Update()
    {
        float deslocamento = Mathf.Repeat(Time.time * velocidade, tamanhoRealDaImagem);
        transform.position = posicaoInicial + Vector3.left * deslocamento;
    }
}
