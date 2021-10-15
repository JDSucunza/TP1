using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerParedYSpawn : MonoBehaviour
{
    
    public GameObject paredADestruir;
    public Transform [] spot;

    public Transform [] enemies;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider c){
        if (c.gameObject.CompareTag ("Player")){
            Destroy (paredADestruir);
            
        }
    }
}
