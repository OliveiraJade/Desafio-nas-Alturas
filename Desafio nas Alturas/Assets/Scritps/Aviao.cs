﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    Rigidbody2D fisica;
    [SerializeField]
    private float forca = 10f;

    private void Awake()
    {
        Debug.Log("Acordei");
        this.fisica = GetComponent<Rigidbody2D>();
    }

    private void Impulsionar()
    {
        this.fisica.AddForce(Vector2.up * forca, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Clicou");
            Impulsionar();
        }
    }
}
