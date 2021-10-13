using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    
    public float tamanioPrefab;
    public int balas;
    public GameObject prefab;

    public GameObject jugador;
    public string nombreDeAccion;


    void Update()
    {
        if (Input.GetButtonDown (nombreDeAccion)){
            InvokeRepeating ("Disparo",0, 0.2f);
        }

        if (Input.GetButtonUp (nombreDeAccion) || balas == 0){
            CancelInvoke ("Disparo");
        }
    }

    void Disparo (){
        Instantiate (prefab, jugador.transform.position + (Vector3.forward * tamanioPrefab),jugador.transform.rotation);
            balas = balas - 1;
    }
}