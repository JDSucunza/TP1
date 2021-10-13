using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class RandomSpawn : MonoBehaviour
{
    
    public Transform [] puntos;

    
    public GameObject prefab;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke ("RandomSpawnPoint", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RandomSpawnPoint (){
        int randomPos = Random.Range (0, this.puntos.Length);
        Instantiate (this.prefab, this.puntos[randomPos].position, this.transform.rotation);
    }
}
