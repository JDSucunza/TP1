using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLevel1 : MonoBehaviour
{
    public GameObject player;

    public GameObject finish;
    public float timer = 0f;

    public float maxTime= 500f;
    public bool gano = false;

    public bool murio = false;

   
     
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gano!= true && murio != true && timer < maxTime){
            timer = timer + (1*Time.deltaTime);
        }else if (murio || TiempoCumplido () ){    
            
            SceneManager.LoadScene("1Final");
        } else {
            SceneManager.LoadScene ("3Final");
        }
    }

    bool TiempoCumplido (){
        return (timer >= maxTime);
    }
    
    void Murio (){

        Vida player = gameObject.GetComponent <Vida>();
        if (player.dead){
            murio = true;
        }
    
    }

    void Gano (){

    }
}
