﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour {

    public float lookRadius = 10f;
    public GameObject player;
    Transform target;
    NavMeshAgent agent;


	// Use this for initialization
	void Start () {

        target = PlayerManager.instance.Player.transform;
        agent = GetComponent<NavMeshAgent>();
	}

    // Update is called once per frame
    void Update() {

            float distance = Vector3.Distance(target.position, transform.position);

            if (distance <= lookRadius)
            {
                agent.SetDestination(target.position);

            }
        
        
	}

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.name == "player")
        {

            Destroy(player);
        }
    }



}
