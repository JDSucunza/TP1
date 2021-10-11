using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel1 : MonoBehaviour
{
    public GameObject player;

    public bool gano = false;

     
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider c){
        if (c==player){
            gano = true;
        }
    }
}
