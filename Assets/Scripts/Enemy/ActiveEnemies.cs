using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveEnemies : MonoBehaviour
{
   
    public GameObject [] enemigos;

    public GameObject paredSector2;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider c){
        if(c.CompareTag("Player")){
            
            foreach(GameObject enemigo in enemigos){
                enemigo.SetActive(true);
            }
            Destroy (paredSector2);
            Destroy(this.gameObject);
        }
    }
    

    

}
