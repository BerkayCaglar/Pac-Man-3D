using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class GhostController : MonoBehaviour
{
    private GameObject target;
    private SpawnManager spawnManager;
    void FixedUpdate()
    {
        NavMeshGhostFollowingTheTarget();
    }
    private void Start() {
        spawnManager=GameObject.Find("Spawn Manager").GetComponent<SpawnManager>();
    }
    private void NavMeshGhostFollowingTheTarget()
    {
        if(gameObject.CompareTag("Ghost Red"))
        {
            GetComponent<NavMeshAgent>().destination = spawnManager.ghostTargets["Ghost Red"].transform.position;
        }
        if(gameObject.CompareTag("Ghost White"))
        {
            GetComponent<NavMeshAgent>().destination = spawnManager.ghostTargets["Ghost White"].transform.position;
        }
        if(gameObject.CompareTag("Ghost Blue"))
        {
            GetComponent<NavMeshAgent>().destination = spawnManager.ghostTargets["Ghost Blue"].transform.position;
        }
        if(gameObject.CompareTag("Ghost Pink"))
        {
            GetComponent<NavMeshAgent>().destination = spawnManager.ghostTargets["Ghost Pink"].transform.position;
        }
        if(gameObject.CompareTag("Ghost Brown"))
        {
            GetComponent<NavMeshAgent>().destination = spawnManager.ghostTargets["Ghost Brown"].transform.position;
        }
    }
}