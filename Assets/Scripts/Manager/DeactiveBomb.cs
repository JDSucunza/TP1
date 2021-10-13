using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactiveBomb : MonoBehaviour
{
    public bool active = true;

    public GameObject player;
    
    void Awake()
    {
        if (player ==null){
            Debug.Log ("Player is not defined for DeactiveBomb");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter (Collision c){
        
        if (c.gameObject == player){
            active = false;
        }
    }
}
