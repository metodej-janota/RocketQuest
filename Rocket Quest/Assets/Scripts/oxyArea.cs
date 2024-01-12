using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oxyArea : MonoBehaviour
{
    public float oxyA = 1;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerStats>().giveOxy(oxyA * Time.deltaTime * 10);
        }
    }
}
