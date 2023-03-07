using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catch : MonoBehaviour
{
   Counter contadorDeInimigos;

   void Start()
    {
        contadorDeInimigos = FindObjectOfType<Counter>();
    }
   void OnCollisionEnter(Collision objeto)
    {
        if(objeto.gameObject.tag == "Enemy")
        {
            Debug.Log("Bateu!");
            contadorDeInimigos.Increment();
        }
    }
}
