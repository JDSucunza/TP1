using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactiveBomb : MonoBehaviour
{
    public bool active = true;

    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
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
        active = false;
    }

}
