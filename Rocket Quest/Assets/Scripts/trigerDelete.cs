using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigerDelete : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        Destroy(gameObject);
    }
}
