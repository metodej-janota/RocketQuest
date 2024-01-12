using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxyTank : MonoBehaviour
{
    public float oxyA = 50f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerStats>().giveOxy(oxyA);
            Destroy(gameObject);
        }
    }
}
