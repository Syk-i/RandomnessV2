﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonEnemy : Enemy {


    public Transform target;
    public float chaseRadius;
    public float attackRadius;
    public Transform homePosition;
    public int DemonHealth;
    
    
    
    // Use this for initialization
   
    void Start () {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        

    }
   
    // Update is called once per frame
    void Update () {
        CheckDistance();
        
        
	}
    void CheckDistance()
    {
        if(Vector3.Distance(target.position, transform.position)<= chaseRadius && Vector3.Distance(target.position, transform.position) > attackRadius)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "Player")
        {
            Debug.Log("Hello");

        }

       
        
    }
    
}
