using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    
    public GameObject player;

    public GameObject bomb;
    
    
    void Awake (){
        Vida lifePlayer = player.GetComponent <Vida>();
    
        DeactiveBomb statusBomb = bomb.GetComponent <DeactiveBomb> ();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void Ganar (){
        print ("Gano");
    }
}
