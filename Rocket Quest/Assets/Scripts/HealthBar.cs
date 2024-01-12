using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthSlider;

    public void setSlider(float a)
    {
        healthSlider.value = a;
    }
    
    public void setSliderMax(float a)
    {
        healthSlider.maxValue = a;
        setSlider(a);
    }
}
