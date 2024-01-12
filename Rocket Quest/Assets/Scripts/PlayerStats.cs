using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public GameObject overScreen;
    public GameObject mainUI;
    public GameObject astronautPlayer;
    public Effekty effekty;
	public AudioSource bolest;
    // health
    [SerializeField] private float maxHealth;
    private float currentHealth;
    public HealthBar healthBar;
    
    //oxy
    
    [SerializeField] private float maxOxy;
    private float currentOxy;
    public OxyBar OxyBar;
    private float nextActionTime = 0.0f;
    public float period = 15f;
    
    private void Start()
    {
        //hrac
        astronautPlayer.SetActive(true);
        //UI
        overScreen.SetActive(false);
        mainUI.SetActive(true);
        //ziv
        currentHealth = maxHealth;
        healthBar.setSliderMax(maxHealth);
        
        //oxy
        currentOxy = maxOxy;
        OxyBar.setSliderMax(maxOxy);
    }

private void ResetPlayerStats()
{
    currentHealth = maxHealth;
    healthBar.setSlider(currentHealth);
    currentOxy = maxOxy;
    OxyBar.setSlider(currentOxy);
}

    public void takeDamage(float a)
    {
        currentHealth -= a;
        healthBar.setSlider(currentHealth);
    }
    
    public void takeOxy(float a)
    {
        currentOxy -= a;
        OxyBar.setSlider(currentOxy);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Die();
        }
        //Take oxy
        if (Time.time > nextActionTime ) {
            if (currentOxy <= 0)
            {
                nextActionTime += period;
                takeDamage(2f);
				effekty.ShakeCamera();
				bolest.Play();
            }
            else
            {
                nextActionTime += period;
                takeOxy(10f);
            }
        }

        if (currentHealth <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        astronautPlayer.SetActive(false);
        mainUI.SetActive(false);
        gameOverScreen();
		ResetPlayerStats();
    }

    public void Heal(float a)
    {
        if (a + currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
            healthBar.setSlider(currentHealth);
        }
        else
        {
            currentHealth += a;
            healthBar.setSlider(currentHealth);
        }
    }
    public void giveOxy(float a)
    {
        if (a + currentOxy > maxOxy)
        {
            currentOxy = maxOxy;
            OxyBar.setSlider(currentOxy);
        }
        else
        {
            currentOxy += a;
            OxyBar.setSlider(currentOxy);
        }
    }

    public void gameOverScreen()
    {
        overScreen.SetActive(true);
        mainUI.SetActive(false);
    }
}
