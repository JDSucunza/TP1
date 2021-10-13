using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform target;
    private Rigidbody rb;
    public float speed = 5f;
    public GameObject player; 
    
    public EnemyManager enemyManager;
    

    private void Awake(){
        this.rb = this.GetComponent<Rigidbody>();
        
        /*this.player = GameObject.FindWithTag("Player");
        if(this.player == null){
            Debug.Log("Player is null in EnemyManager");
        }*/
        
    
    }


    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Vector3.MoveTowards(this.transform.position, this.target.position, this.speed * Time.deltaTime);
        this.rb.MovePosition(pos);
        
    }
}
