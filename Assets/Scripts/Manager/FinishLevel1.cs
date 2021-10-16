using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLevel1 : MonoBehaviour
{
    public GameObject player;

    public GameObject bomb;
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
        if (Active () && Murio () != true && timer < maxTime){
            timer = timer + (1*Time.deltaTime);
        }else if (Murio() || TiempoCumplido () ){    
            
            SceneManager.LoadScene("1Final");
        } else {
            SceneManager.LoadScene ("3Final");
        }
    }
    
    bool TiempoCumplido (){
        return (timer >= maxTime);
    }
    
    private bool Murio (){

        Vida playerVida = player.gameObject.GetComponent <Vida>();
            return (playerVida.dead);
        }
    
    

    private bool Active (){
        DeactiveBomb bombActive = bomb.gameObject.GetComponent <DeactiveBomb> ();
        return (bombActive.active);
    }
}
