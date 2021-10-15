using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerParedYSpawn : MonoBehaviour
{
    public GameObject paredADestruir;
    public Transform spot;

    public GameObject prefab;
    

   // public GameObject [] enemies;

    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider c){
        if (c.gameObject.CompareTag ("Player")){
            Debug.Log (this.spot);
            Debug.Log (this.prefab);
            Destroy (paredADestruir);
            Instantiate (this.prefab, this.spot.position, this.spot.rotation);
        }

    }

    void ActivarEnemigos (){
       
       Instantiate (this.prefab, this.spot.position, this.spot.rotation);
       /* for (int i = 0 ; i< enemies.Length; i++){
            enemies[i].gameObject.SetActive (true); 
        }*/
    }
}
