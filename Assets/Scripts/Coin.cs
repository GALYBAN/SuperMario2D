using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour

{

    private AudioSource source; 

    public AudioClip coinSound;

    [SerializeField] private float coinCounter;
    [SerializeField] private Counter counter;


        void Awake() 
        {
             source = GetComponent<AudioSource>();
        }

        void OnTriggerEnter2D(Collider2D collider)
            {
                if(collider.gameObject.tag == "Player")
                {
                    counter.SumarMonedas(coinCounter);
                    source.PlayOneShot(coinSound);
                    Destroy(gameObject, 0.5F);
                } 
            }
}
