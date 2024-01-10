using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 newPosition = new Vector3(50, 5, 0);

    public float movementSpeed = 10;

    private float inputHorizontal;

    public bool jump = false;

    // Start is called before the first frame update
    void Start()
    {
        //Teletransporta al personaje a la posicion de la variable newPosition
        //transform.position = newPosition;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = transform.position + new Vector3(1, 0, 0) * movementSpeed * Time.deltaTime;
        inputHorizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(inputHorizontal, 0, 0) * movementSpeed * Time.deltaTime;

        if(jump == true)
        {
            Debug.Log("estoy saltando");
        }
        else
        {
            Debug.Log("estoy en el suelo");
        }
    }
}
