using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnEnemy : MonoBehaviour
{
    
    public Transform [] spot;

    public Transform [] enemies;

    public float start;

    public float repeat;

    public GameObject manager;

    public int enemyMax;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("RandomSpawnPoint", start, repeat);
 
        
    }

    

    // Update is called once per frame
    void Update()
    {
     
    }

      void RandomSpawnPoint (){
        EnemyManager enemyManager = manager.GetComponent <EnemyManager>();
        int randomPos = Random.Range (0, this.spot.Length);
        int randomPosE = Random.Range (0, this.enemies.Length);
        if (enemyManager.countEnemy < enemyMax){
            enemyManager.countEnemy = enemyManager.countEnemy + 1;
            Instantiate (this.enemies[randomPosE], this.spot[randomPos].position, this.transform.rotation);
        }
    }
}
