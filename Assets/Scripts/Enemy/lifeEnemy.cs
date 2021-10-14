using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifeEnemy : MonoBehaviour
{
   
   
    public int vida = 200;

    private GameObject enemy;

    public GameObject  manager;     
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
        
        if (c.gameObject.CompareTag ("Bullet")){
        Damage enemy = c.gameObject.GetComponent <Damage>();
        vida = vida - enemy.damage;
        }
    }
    void Morir (){
        if (vida <= 0){
                EnemyManager enemyManager = manager.GetComponent <EnemyManager>();
                enemyManager.dead = enemyManager.dead + 1;
                
                Destroy (this.gameObject);
                        
        }
    }
}