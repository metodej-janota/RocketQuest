using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedKitHeal : MonoBehaviour
{
    public float healA = 5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerStats>().Heal(healA);
            Destroy(gameObject);
        }
    }
}
