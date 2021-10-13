using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootenemy1 : MonoBehaviour
{
    
    public GameObject prefabBullet;
    
    public float sizePrefab;
    
    public float cooldown = 3f;
    public int maxTime = 8;
    private float _cooldown;
    
    
    
    void Awake (){
        
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (this._cooldown <= 0){
            
         Instantiate (this.prefabBullet, this.transform.position + (Vector3.forward * this.sizePrefab) ,this.transform.rotation);
         this._cooldown = Random.Range(1, this.maxTime);   
        } else {
               this._cooldown = this._cooldown -1 * Time.deltaTime;
        }
    }

}

