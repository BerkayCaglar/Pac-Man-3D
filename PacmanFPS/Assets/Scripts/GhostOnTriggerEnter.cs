using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostOnTriggerEnter : MonoBehaviour
{
    private SpawnManager spawnManager;
    private void Start() {
        spawnManager=GameObject.Find("Spawn Manager").GetComponent<SpawnManager>();
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Target"))
        {
            CheckWhichGhostTheTargetBelongsTo(other);
        }
    }

    private void CheckWhichGhostTheTargetBelongsTo(Collider other)
    {
        if(gameObject.CompareTag("Ghost Red") && other.gameObject == spawnManager.ghostTargets["Ghost Red"])
        {
            spawnManager.ghostTargets.Remove("Ghost Red");
            Destroy(other.gameObject);
            spawnManager.SpawnTargetGhostRed();
        }
        if(gameObject.CompareTag("Ghost White") && other.gameObject == spawnManager.ghostTargets["Ghost White"])
        {
            spawnManager.ghostTargets.Remove("Ghost White");
            Destroy(other.gameObject);
            spawnManager.SpawnTargetGhostWhite();
        }
        if(gameObject.CompareTag("Ghost Blue") && other.gameObject == spawnManager.ghostTargets["Ghost Blue"])
        {
            spawnManager.ghostTargets.Remove("Ghost Blue");
            Destroy(other.gameObject);
            spawnManager.SpawnTargetGhostBlue();
        }
        if(gameObject.CompareTag("Ghost Pink") && other.gameObject == spawnManager.ghostTargets["Ghost Pink"])
        {
            spawnManager.ghostTargets.Remove("Ghost Pink");
            Destroy(other.gameObject);
            spawnManager.SpawnTargetGhostPink();
        }
        if(gameObject.CompareTag("Ghost Brown") && other.gameObject == spawnManager.ghostTargets["Ghost Brown"])
        {
            spawnManager.ghostTargets.Remove("Ghost Brown");
            Destroy(other.gameObject);
            spawnManager.SpawnTargetGhostBrown();
        }
    }
}
