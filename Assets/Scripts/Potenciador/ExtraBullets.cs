using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraBullets : MonoBehaviour
{
    public int bullets;
    
    private GameObject player;
    
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void OnTriggerEnter (Collider c){
        if (c.gameObject.CompareTag ("Player")){
                
                Shoot player = c.gameObject.GetComponent <Shoot> ();
            
                Destroy (this.gameObject);
                player.balas = player.balas + bullets;
            
        }
    }    
}