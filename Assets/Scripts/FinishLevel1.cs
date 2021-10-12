using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLevel1 : MonoBehaviour
{
    public GameObject player;

    
    public bool gano = false;

     
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gano){
            
            SceneManager.LoadScene("3Final");
        }
    }

    void OnTriggerEnter (Collider c){
        if (c.CompareTag ("Player")){
            gano = true;
        }
    }
}
