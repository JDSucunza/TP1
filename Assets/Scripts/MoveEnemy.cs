using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    
    public int speedVert;
    public int speedHor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       this.transform.Translate (speedHor * Time.deltaTime, 0, speedVert * Time.deltaTime); 
    }
}
