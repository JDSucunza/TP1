using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeRecover : MonoBehaviour
{
    
    public int lifeRec;
    
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
           Vida player = c.gameObject.GetComponent <Vida> ();
            if (player.vida < 100){
                Destroy (this.gameObject);
            }
            
            if (player.vida + lifeRec < 100){
                    player.vida = player.vida + lifeRec;
            } else {
                    player.vida = 100;
            }
            
        }
    }    
}
