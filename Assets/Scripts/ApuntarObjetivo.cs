using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApuntarObjetivo : MonoBehaviour
{
    
    
    private Transform player;
    
    // Start is called before the first frame update
    
     void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
       
    }

   
   // ARREGLAR!!!!!
   void Apuntar (){
      //GameObject player = GameObject.Find ("Player");
      
      this.transform.LookAt(this.player);
   }

} 
