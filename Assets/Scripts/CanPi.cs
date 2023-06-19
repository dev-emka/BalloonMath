using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanPi : MonoBehaviour
{
    public GameObject can1, can2, can3;
    LevelManager levelManager;
    private void Start()
    {
        levelManager = Object.FindObjectOfType<LevelManager>();

    }
    public void CanlariKontrolEt(int KalanCan)
    {
        switch (KalanCan)
        {
            case 3:
                can1.SetActive(true);
                can2.SetActive(true);
                can3.SetActive(true);
                break;

            case 2:
                can1.SetActive(true);
                can2.SetActive(true);
                can3.SetActive(false);
                break;

            case 1:
                
                can1.SetActive(true);
                can2.SetActive(false);
                can3.SetActive(false);
                break;

            case 0:
                can1.SetActive(false);
                can2.SetActive(false);
                can3.SetActive(false);
                levelManager.PlayerWasDead();
                break;
        }

            

    } 
}
