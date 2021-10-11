using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    
    public int vida;

    private GameObject enemy;
    
    

    public bool dead = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.Morir ();
    }

    // ARREGLAR !!!
    
    void OnCollisionEnter (Collision c){
        Damage enemy = c.gameObject.GetComponent <Damage>();
        vida = vida - enemy.damage;
    }
    
    void Morir (){
        if (vida <= 0){
                this.dead = true;        
        }
    }
}

