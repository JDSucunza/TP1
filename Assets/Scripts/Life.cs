using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    
    public float cant;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cant <= 0){
            Destroy (gameObject);
        }    
    }

    void Life (){
        this.cant = cant;
    }
}
