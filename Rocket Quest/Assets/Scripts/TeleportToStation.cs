using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TeleportToStation : MonoBehaviour
{
	public Image componentsNotComplete;
	public int sceneIndex;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
			bool complete = other.GetComponent<playerInventory>().itemsCheck();
			if(complete == true){
				SceneManager.LoadScene(sceneIndex);
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
