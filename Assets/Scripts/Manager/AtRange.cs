using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtRange : MonoBehaviour
{
    public GameObject player;
    public float rango;

    private void Awake(){
        this.player = GameObject.FindWithTag("Player");
        if(this.player == null){
            Debug.Log("Player is null in EnemyManager");
        }
    }

    void update (){
        this.JugadorEnRango ();
    }
    public bool JugadorEnRango(){
        return Vector3.Distance(this.transform.position, this.player.transform.position) < this.rango;
    }
}
