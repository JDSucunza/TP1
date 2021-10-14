using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    
    public int speedH;

    public int speedV;
    
    
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
            speedV = -speedV;
            speedH = -speedH;
    }

}
