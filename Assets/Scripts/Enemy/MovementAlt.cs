using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    public int speedH;

    public int speedV;
    
    public bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate (speedH * Time.deltaTime, 0, speedV * Time.deltaTime); 
    }

    void OnCollisionEnter (Collision c){

    }

}
