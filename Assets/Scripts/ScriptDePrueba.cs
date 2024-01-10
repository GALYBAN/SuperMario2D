using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDePrueba : MonoBehaviour
{

    public int vidasPersonaje = 100;
    public int vidasPersonaje2 = 3;
    public float numeroDecimal = 4.5f;
    public string nombrePersonaje = "Super Mario";
    private bool interruptor = true;

    // Start is called before the first frame update
    void Start()
    {
        vidasPersonaje = 10;

        int suma = vidasPersonaje + vidasPersonaje2;
        Debug.Log(suma);
        
        Debug.Log(nombrePersonaje);
        Debug.Log(vidasPersonaje);
        Debug.Log(numeroDecimal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
