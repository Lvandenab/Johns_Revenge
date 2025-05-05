using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent agent;
    public float health = 2f;
    public Transform player; 
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.position);

    }
    void die()
    {
        Destroy(gameObject);
    }
    public void takedamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            die();
        }
    }
}
