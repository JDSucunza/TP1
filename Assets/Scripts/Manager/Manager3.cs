using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager3 : MonoBehaviour
{
    
    public float timer = 0f;

    public float maxTime = 60f;

    public GameObject final;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Termino () != true && timer < maxTime){
            timer = timer + (1 * Time.deltaTime);
        } else if (Termino ()){
            SceneManager.LoadScene("2Final");
            } else {
                    SceneManager.LoadScene("3Final");
            }
    }

    private bool Termino (){

        Finish esFinal = final.gameObject.GetComponent <Finish>();
        return (esFinal.finish);

    }


}
