using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxyBar : MonoBehaviour
{
    public Slider oxySlider;

    public void setSlider(float a)
    {
        oxySlider.value = a;
    }
    
    public void setSliderMax(float a)
    {
        oxySlider.maxValue = a;
        setSlider(a);
    }
}
