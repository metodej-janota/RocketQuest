using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class makeSpaceShip : MonoBehaviour
{
    public GameObject spaceShip;
    public Image componentsNotComplete;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            bool complete = other.GetComponent<playerInventory>().crystalCheck();
            if(complete == true){
                spaceShip.SetActive(true);
            }else{
                componentsNotComplete.gameObject.SetActive(true);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        componentsNotComplete.gameObject.SetActive(false);
    }
}
