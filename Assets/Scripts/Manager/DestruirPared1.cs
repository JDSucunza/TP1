using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirPared1 : MonoBehaviour
{
    
    public GameObject paredADestruir;
    
    public EnemyManager manager;
    
    void Awake (){
        manager = manager.gameObject.GetComponent <EnemyManager> ();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (manager.dead == 8){
            Destroy (paredADestruir);
        }
    }
}
