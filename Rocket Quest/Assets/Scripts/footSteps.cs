using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footSteps : MonoBehaviour
{
    public GameObject footstep;
    
    void Start()
    {
        footstep.SetActive(false);
    }
    
    void Update()
    {
        if(Input.GetKey("w"))
        {
            footsteps();
        }

        if(Input.GetKeyDown("s"))
        {
            footsteps();
        }

        if(Input.GetKeyDown("a"))
        {
            footsteps();
        }

        if(Input.GetKeyDown("d"))
        {
            footsteps();
        }

        if(Input.GetKeyUp("w"))
        {
            StopFootsteps();
        }

        if(Input.GetKeyUp("s"))
        {
            StopFootsteps();
        }

        if(Input.GetKeyUp("a"))
        {
            StopFootsteps();
        }

        if(Input.GetKeyUp("d"))
        {
            StopFootsteps();
        }

    }

    void footsteps()
    {
        footstep.SetActive(true);
    }

    void StopFootsteps()
    {
        footstep.SetActive(false);
    }
}
