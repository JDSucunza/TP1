using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager2 : MonoBehaviour
{
    public float timer = 0f;
    public float maxTime = 60f;
    public GameObject final;
    private GameObject player;
    
    void Awake (){
        player = GameObject.FindWithTag ("Player");
    }

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Termino () != true && Dead () != true && TiempoCumplido () != true){
            timer = timer + (1 * Time.deltaTime);
        } else if (Termino () != true && Dead () || TiempoCumplido ()){
            SceneManager.LoadScene("2Final");
            } else {
                    SceneManager.LoadScene("3Final");
            }
        
    }

    private bool TiempoCumplido (){
        return (maxTime <= timer);
    }
    
    private bool Termino (){

        Finish esFinal = final.gameObject.GetComponent <Finish>();
        return (esFinal.finish);

    }

    private bool Dead (){
        Vida muerto = player.gameObject.GetComponent <Vida> ();
        return (muerto.dead);
    }

}
