using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    private float monedas;

    private TextMeshProUGUI textMesh;
    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        textMesh.text = monedas.ToString("0");
    }

    public void SumarMonedas(float monedasEntrada)
    {
        monedas += monedasEntrada;
    }
}
