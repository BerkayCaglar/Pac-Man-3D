using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class SpawnManager : MonoBehaviour
{
    private Vector3 randomPosition;
    private NavMeshHit hit;
    [SerializeField]
    private GameObject target;
    public Dictionary<string,GameObject> ghostTargets = new Dictionary<string, GameObject>();
    void Start()
    {
        SpawnEveryTargetForGhosts();
    }
    private Vector3 RandomPositionInsideTheNavMesh()
    {
        randomPosition = new Vector3(Random.Range(-100,100),0.5f,Random.Range(-100,100));
        NavMesh.SamplePosition(randomPosition,out hit,Mathf.Infinity,NavMesh.GetAreaFromName("Base"));
        return hit.position;
    }
    
    private void SpawnEveryTargetForGhosts()
    {
        SpawnTargetGhostRed();
        SpawnTargetGhostWhite();
        SpawnTargetGhostBlue();
        SpawnTargetGhostPink();
        SpawnTargetGhostBrown();
    }

    public void SpawnTargetGhostRed()
    {
        ghostTargets.Add("Ghost Red",Instantiate(target,RandomPositionInsideTheNavMesh(),target.transform.rotation));
    }
    public void SpawnTargetGhostWhite()
    {
        ghostTargets.Add("Ghost White",Instantiate(target,RandomPositionInsideTheNavMesh(),target.transform.rotation));
    }
    public void SpawnTargetGhostBlue()
    {
        ghostTargets.Add("Ghost Blue",Instantiate(target,RandomPositionInsideTheNavMesh(),target.transform.rotation));
    }
    public void SpawnTargetGhostPink()
    {
        ghostTargets.Add("Ghost Pink",Instantiate(target,RandomPositionInsideTheNavMesh(),target.transform.rotation));
    }
    public void SpawnTargetGhostBrown()
    {
        ghostTargets.Add("Ghost Brown",Instantiate(target,RandomPositionInsideTheNavMesh(),target.transform.rotation));
    }
}
