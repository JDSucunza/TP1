using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    
    public int damage;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnColiisionEnter (Collision c ){
        Vida vidaDelObjeto = c.gameObject.GetComponent <Vida>();
        if (vidaDelObjeto.vida > damage){
            vidaDelObjeto.vida = vidaDelObjeto.vida - damage;
        }   else {
            Destroy (c.gameObject);
        }
    }      
                                                               
}
