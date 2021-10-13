using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    
    public int life = 100;
    public GameObject manager;
    
   
    // Update is called once per frame
    void Update()
    {
        
      this.Morir();
    }

    void Morir (){
        if (life == 0){
            EnemyManager enemyManager = manager.GetComponent <EnemyManager>();
            enemyManager.dead = enemyManager.dead + 1;
            enemyManager.countEnemy = enemyManager.countEnemy - 1;
            Destroy (this.gameObject);

        }
    }

}
