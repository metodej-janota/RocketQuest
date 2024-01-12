using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    [SerializeField] private float duration;

    public void Nahoru(Transform target)
    {
        transform.DOLookAt(target.position, duration);
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    
    public void One()
    {
        SceneManager.LoadScene(1);
    }
    
    public void Two()
    {
        SceneManager.LoadScene(2);
    }
    
    public void Three()
    {
        SceneManager.LoadScene(3);
    }
}
