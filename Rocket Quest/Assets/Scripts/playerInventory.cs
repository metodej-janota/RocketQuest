using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerInventory : MonoBehaviour
{
	public AudioSource pickupSound;
    //Engine
    //Pridat obrazky
    //pridat menu
	//pridat ui prvek upozornujicí na prechod do lokace 
    private float engineCount = 0;
    private float engineCountToComplete = 0;
    public Text engineCountText;
	public Image old_engineSprite;
	public Sprite new_engineSprite;
    
    // Seat
    private float seatCount = 0;
    private float seatCountToComplete = 0;
    public Text seatCountText;
	public Image old_SeatSprite;
	public Sprite new_SeatSprite;
    
    // scrap
    private float scrapCount = 0;
    private float scrapCountToComplete = 0;
    public Text scrapCountText;
	public Image old_scrapSprite;
	public Sprite new_scrapSprite;
    
    // flatche
    private float flatcheCount = 0;
    private float flatchCountToComplete = 0;
    public Text flatchCountText;
	public Image old_flatcheSprite;
	public Sprite new_flatcheSprite;
    
    // filter
    private float filterCount = 0;
    private float filterCountToComplete = 0;
    public Text filterCountText;
	public Image old_filterSprite;
	public Sprite new_filterSprite;
    
    // crystal
    private float crystalCount = 0;
    private float crystalCountToComplete = 0;
    public Text crystalCountText;
	public Image old_crystalSprite;
	public Sprite new_crystalSprite;
    
    //Tools
	private bool needPickaxe = false;
    private bool pickaxe = false;

    private void Start(){
		Scene currentScene = SceneManager.GetActiveScene ();
		string sceneName = currentScene.name;
		if (sceneName == "outside") 
		{
			engineCountToComplete = 1;
    		seatCountToComplete = 1;
			scrapCountToComplete = 4;
			flatchCountToComplete = 3;
			filterCountToComplete = 2;
			crystalCountToComplete = 0;
			needPickaxe = false;
		}else if (sceneName == "station")
		{
			engineCountToComplete = 1;
    		seatCountToComplete = 0;
			scrapCountToComplete = 1;
			flatchCountToComplete = 2;
			filterCountToComplete = 1;
			crystalCountToComplete = 0;
			needPickaxe = true;
		}else if (sceneName == "final_outside")
		{
			engineCountToComplete = 0;
			seatCountToComplete = 0;
			scrapCountToComplete = 0;
			flatchCountToComplete = 0;
			filterCountToComplete = 0;
			crystalCountToComplete = 4;
			needPickaxe = true;
		}

        engineCountText.text = engineCount + "/" + engineCountToComplete;
        seatCountText.text = seatCount + "/" + seatCountToComplete;
        scrapCountText.text = scrapCount + "/" + scrapCountToComplete;
        flatchCountText.text = flatcheCount + "/" + flatchCountToComplete;
        filterCountText.text = filterCount + "/" + filterCountToComplete;
        crystalCountText.text = crystalCount + "/" + crystalCountToComplete;

		startCompleteCheck();
    }
    
    public void addItem(float a)
    {
	    pickupSound.Play();
        if(a == 0){
            engineCount++;
            engineCountText.text = engineCount + "/" + engineCountToComplete;
            if(engineCount == engineCountToComplete){
                old_engineSprite.sprite = new_engineSprite;
            }
        }else if(a == 1){
            seatCount++;
            seatCountText.text = seatCount + "/" + seatCountToComplete;
            if(seatCount == seatCountToComplete){
                old_SeatSprite.sprite = new_SeatSprite;
            }
        }else if(a == 2){
            scrapCount++;
            scrapCountText.text = scrapCount + "/" + scrapCountToComplete;
            if(scrapCount == scrapCountToComplete){
                old_scrapSprite.sprite = new_scrapSprite;
            }
        }else if(a == 3){
            flatcheCount++;
            flatchCountText.text = flatcheCount + "/" + flatchCountToComplete;
            if(flatcheCount == flatchCountToComplete){
                old_flatcheSprite.sprite = new_flatcheSprite;
            }
        }else if(a == 4){
            filterCount++;
            filterCountText.text = filterCount + "/" + filterCountToComplete;
            if(filterCount == filterCountToComplete){
                old_filterSprite.sprite = new_filterSprite;
            }
        }else if(a == 5){
            crystalCount++;
            crystalCountText.text = crystalCount + "/" + crystalCountToComplete;
            if(crystalCount == crystalCountToComplete){
                old_crystalSprite.sprite = new_crystalSprite;
            }
        }
        else if(a == 6){
            //pickaxe
            pickaxe = true;
        }
    }

	public void startCompleteCheck()
	{
            if(crystalCount == crystalCountToComplete){
                old_crystalSprite.sprite = new_crystalSprite;
            }
            if(filterCount == filterCountToComplete){
                old_filterSprite.sprite = new_filterSprite;
            }
            if(flatcheCount == flatchCountToComplete){
                old_flatcheSprite.sprite = new_flatcheSprite;
            }
            if(scrapCount == scrapCountToComplete){
                old_scrapSprite.sprite = new_scrapSprite;
            }
            if(seatCount == seatCountToComplete){
                old_SeatSprite.sprite = new_SeatSprite;
            }
            if(engineCount == engineCountToComplete){
                old_engineSprite.sprite = new_engineSprite;
            }
	}


    public bool pickaxeCheck()
    {
        return pickaxe;
    }

    public bool crystalCheck()
    {
        if(crystalCount == crystalCountToComplete){
			return true;
		}else{
			return false;
		}
    }

	public bool itemsCheck(){
		bool complete = true; 
		if(engineCount != engineCountToComplete){
			complete = false;
        }
		if(seatCount != seatCountToComplete){
			complete = false;
        }
		if(scrapCount != scrapCountToComplete){
			complete = false;
        }
		if(flatcheCount != flatchCountToComplete){
			complete = false;
        }
		if(filterCount != filterCountToComplete){
			complete = false;
        }
		if(crystalCount != crystalCountToComplete){
			complete = false;
        }if(needPickaxe == true){
			if(pickaxe == false){
				complete = false;
			}
		}
	
		return complete;
	}
}
