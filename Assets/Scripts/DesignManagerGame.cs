using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DesignManagerGame : MonoBehaviour
{
    public GameObject restartbtn, menubtn, cevapbtn, ballon1, ballon2, puandesign, puandesign2, candesign, candesign1, candesign2;

    //Oyun Ýçerisindeki Buton ve Objelerin Tasarým Dizileri
    public Sprite[] rectangleImg = new Sprite[8];
    public Sprite[] squareImg = new Sprite[8];
    public Sprite[] squareRootImg = new Sprite[8];
    public Sprite[] canPiImg = new Sprite[8];
    public Sprite[] ballonsImg = new Sprite[8];

    private void Awake()
    {
        if (PlayerPrefs.GetString("Design") == "A")
        {
            InGameDesignA();
        }

        if (PlayerPrefs.GetString("Design") == "B")
        {
            InGameDesignB();
        }

        if (PlayerPrefs.GetString("Design") == "C")
        {
            InGameDesignC();
        }

        if (PlayerPrefs.GetString("Design") == "D")
        {
            InGameDesignD();
        }
    }

    
    
    void Update()
    {

        if (PlayerPrefs.GetString("Design") == "A")
        {
            InGameDesignA();
        }

        if (PlayerPrefs.GetString("Design") == "B")
        {
            InGameDesignB();
        }

        if (PlayerPrefs.GetString("Design") == "C")
        {
            InGameDesignC();
        }

        if (PlayerPrefs.GetString("Design") == "D")
        {
            InGameDesignD();
        }

    }

    void InGameDesignA()
    {
       
        restartbtn.GetComponent<Image>().sprite = rectangleImg[0];
        menubtn.GetComponent<Image>().sprite = rectangleImg[0];


        cevapbtn.GetComponent<Image>().sprite = squareImg[0];
        ballon1.GetComponent<Image>().sprite = ballonsImg[0];
        ballon2.GetComponent<Image>().sprite = ballonsImg[1];
        puandesign.GetComponent<Image>().sprite = squareRootImg[0];
        puandesign2.GetComponent<Image>().sprite = squareRootImg[0];
        candesign.GetComponent<Image>().sprite = canPiImg[0];
        candesign1.GetComponent<Image>().sprite = canPiImg[1];
        candesign2.GetComponent<Image>().sprite = canPiImg[0];

    }

    void InGameDesignB()
    {
        
        restartbtn.GetComponent<Image>().sprite = rectangleImg[2];
        menubtn.GetComponent<Image>().sprite = rectangleImg[2];

        cevapbtn.GetComponent<Image>().sprite = squareImg[2];
        ballon1.GetComponent<Image>().sprite = ballonsImg[2];
        ballon2.GetComponent<Image>().sprite = ballonsImg[3];
        puandesign.GetComponent<Image>().sprite = squareRootImg[2];
        puandesign2.GetComponent<Image>().sprite = squareRootImg[2];
        candesign.GetComponent<Image>().sprite = canPiImg[2];
        candesign1.GetComponent<Image>().sprite = canPiImg[3];
        candesign2.GetComponent<Image>().sprite = canPiImg[2];

    }

    void InGameDesignC()
    {
        
        restartbtn.GetComponent<Image>().sprite = rectangleImg[4];
        menubtn.GetComponent<Image>().sprite = rectangleImg[4];

        cevapbtn.GetComponent<Image>().sprite = squareImg[4];
        ballon1.GetComponent<Image>().sprite = ballonsImg[4];
        ballon2.GetComponent<Image>().sprite = ballonsImg[5];
        puandesign.GetComponent<Image>().sprite = squareRootImg[4];
        puandesign2.GetComponent<Image>().sprite = squareRootImg[4];
        candesign.GetComponent<Image>().sprite = canPiImg[4];
        candesign1.GetComponent<Image>().sprite = canPiImg[5];
        candesign2.GetComponent<Image>().sprite = canPiImg[4];

    }

    void InGameDesignD()
    {
        restartbtn.GetComponent<Image>().sprite = rectangleImg[6];
        menubtn.GetComponent<Image>().sprite = rectangleImg[6];

        cevapbtn.GetComponent<Image>().sprite = squareImg[6];
        ballon1.GetComponent<Image>().sprite = ballonsImg[6];
        ballon2.GetComponent<Image>().sprite = ballonsImg[7];
        puandesign.GetComponent<Image>().sprite = squareRootImg[6];
        puandesign2.GetComponent<Image>().sprite = squareRootImg[6];
        candesign.GetComponent<Image>().sprite = canPiImg[6];
        candesign1.GetComponent<Image>().sprite = canPiImg[7];
        candesign2.GetComponent<Image>().sprite = canPiImg[6];

    }

}
