using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootenemy1 : MonoBehaviour
{
    
    public GameObject prefabBullet;
    
    public float sizePrefab;
    
    public int bullets;
    private int   _bullets;
    
    void Awake (){
        this.Reload();
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (_bullets > 0){
           _bullets = bullets; 
         Instantiate (this.prefabBullet, this.transform.position + (Vector3.forward * this.sizePrefab) ,this.transform.rotation);
            _bullets = _bullets - 1;
        } else {
                this.Reload ();
        }
    }

    void Reload (){
        _bullets = bullets;
    }
}

