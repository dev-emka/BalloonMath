using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
   public int level;
    public int deadScore;
    public GameObject skipScreen,txt,gameScreen,DeadScreen;
    public Text skipText;
    PuanKontrol puanKontrol;
    CanPi canKontrol;

    private void Start()
    {
        puanKontrol = Object.FindObjectOfType<PuanKontrol>();
        canKontrol = Object.FindObjectOfType<CanPi>();
    }
    private void Update()
    {
        level = puanKontrol.toplamPuan / 100 + 1; ;

        if (puanKontrol.toplamPuan%100==0)
        {

            skipText.text = "LEVEL" + " " + level.ToString();

        }
                 
    }
    public void PlayerWasDead()
    {
        deadScore = puanKontrol.toplamPuan;

        NowTime.Zamn();
        NowTime.times.Add(NowTime.zaman);
        UserClass.scores.Add(deadScore);
        UserData.SaveScores();
        
        gameScreen.SetActive(false);
        DeadScreen.SetActive(true);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }


   
}
