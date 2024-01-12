using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageArea : MonoBehaviour
{
    public float damageA = 1;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerStats>().takeDamage(damageA * Time.deltaTime);
        }
    }
}
