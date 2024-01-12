using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class item : MonoBehaviour
{

    public float typeOfItem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
			    other.GetComponent<playerInventory>().addItem(typeOfItem);
				Destroy(gameObject);
        }
    }
}
