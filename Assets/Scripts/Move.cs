using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.Movement ();
    }

    
    void Movement (){
        if (Input.GetButton ("up") || Input.GetButton ("down")){
            this.MovVertical ();
        }    
            
        if (Input.GetButton ("left") || Input.GetButton ("right")){    
            this.MovHorizontal ();
        }
    }
    
    
    
    void MovVertical (){
        if (Input.GetButton ("up")){
            this.transform.Translate (0,0, speed * Time.deltaTime);
        }       else {
                    this.transform.Translate (0,0, - speed * Time.deltaTime);
                 }
    }

    void MovHorizontal (){
        if (Input.GetButton ("left")){
            this.transform.Translate (- speed * Time.deltaTime, 0, 0);
        }       else {
                    this.transform.Translate (speed * Time.deltaTime, 0, 0);
                }
    }


}
