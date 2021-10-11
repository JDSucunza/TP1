using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApuntarObjetivo : MonoBehaviour
{
    
    
    public Transform player;
    
    // Start is called before the first frame update
    
     void Start()
    {
       /*if (player ==null){
          Debug.Log ("Player is not assigned");
       }*/
    }

    // Update is called once per frame
    void Update()
    {
       
       
    }

   
   // ARREGLAR!!!!!
   void Apuntar (){
      //GameObject player = GameObject.Find ("Player");
      
      this.transform.LookAt(player);
   }

} 
