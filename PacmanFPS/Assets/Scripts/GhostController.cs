using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class GhostController : MonoBehaviour
{
    private GameObject target;
    private SpawnManager spawnManager;
    private NavMeshAgent agent;
    void FixedUpdate()
    {
        NavMeshGhostFollowingTheTarget();
    }
    private void Start() {
        agent = GetComponent<NavMeshAgent>();
        spawnManager=GameObject.Find("Spawn Manager").GetComponent<SpawnManager>();
    }
    private void NavMeshGhostFollowingTheTarget()
    {
        if(gameObject.CompareTag("Ghost Red"))
        {
            agent.destination = spawnManager.ghostTargets["Ghost Red"].transform.position;
        }
        if(gameObject.CompareTag("Ghost White"))
        {
            agent.destination = spawnManager.ghostTargets["Ghost White"].transform.position;
        }
        if(gameObject.CompareTag("Ghost Blue"))
        {
            agent.destination = spawnManager.ghostTargets["Ghost Blue"].transform.position;
        }
        if(gameObject.CompareTag("Ghost Pink"))
        {
            agent.destination = spawnManager.ghostTargets["Ghost Pink"].transform.position;
        }
        if(gameObject.CompareTag("Ghost Brown"))
        {
            agent.destination = spawnManager.ghostTargets["Ghost Brown"].transform.position;
        }
    }
}