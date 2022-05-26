using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    private AudioClip pointTakeSound;
    private AudioSource audioSource;
    [SerializeField]
    private GameObject pointPrefab;
    private void Start() {
        audioSource = gameObject.GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Point"))
        {
            audioSource.PlayOneShot(pointTakeSound);
            Destroy(other.gameObject);
        }
    }
}
