using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bell_Controllers : MonoBehaviour
{
    public GameObject[] bell;
    public int can,maxcan;
    public GameObject bell1;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemi"))
        {
            bell1.SetActive(false);
        }
    }


    public void Update()
    {
        if(can <=0)
        {
           SceneManager.LoadScene(0); 

        }
    }

    public void CanAzalt()
    {
        can--;
        CanSistemi();
    }

   public void CanSistemi()
    {
        for (int i = 0; i < maxcan ; i++)
        {
            bell[i].SetActive(false);
        }
        for (int i = 0; i < can; i++)
        {
            bell[i].SetActive(true);
        }
    }
}
