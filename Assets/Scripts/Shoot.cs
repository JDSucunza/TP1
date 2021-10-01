using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    
    public GameObject prefabBullet;
    public int bullets = 0;

    public float sizePrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown ("Fire1") && bullets > 0){
           Instantiate (this.prefabBullet, this.transform.position + (Vector3.forward * this.sizePrefab) ,this.transform.rotation);
            bullets = bullets - 1;
        }
    }
}
