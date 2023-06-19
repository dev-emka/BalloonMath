using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DesignManager : MonoBehaviour
{
    //Oyun Ýçerisindeki Butonlar ve GameObjeler
    public GameObject startbtn, exitbtn, designbtn,detailsbtn,bactomenu,deleteusers,savebtn;

    //Design Ekranýndaki Örnekler
    public GameObject exampleBallon,exampleBallon2,exampleCan,exampleCan2,exampleCan3,examplePuan,endHome;


    public GameObject menuScreen, designScreen,detailScreen;

    public Text designtext;


    //Oyun Ýçerisindeki Buton ve Objelerin Tasarým Dizileri
    public Sprite[] rectangleImg = new Sprite[8];
    public Sprite[] squareImg = new Sprite[8];
    public Sprite[] squareRootImg = new Sprite[8];
    public Sprite[] canPiImg = new Sprite[8];
    public Sprite[] ballonsImg = new Sprite[8];

    public DesignManagerGame managerGame;

    private void Start()
    {
        if (PlayerPrefs.GetString("Design") == "A")
        {
            DesignA();
        }

        if (PlayerPrefs.GetString("Design") == "B")
        {
            DesignB();
        }

        if (PlayerPrefs.GetString("Design") == "C")
        {
            DesignC();
        }

        if (PlayerPrefs.GetString("Design") == "D")
        {
            DesignD();
        }
    }

    private void Update()
    {
        if (PlayerPrefs.GetString("Design") == "A")
        {
            DesignA();
        }

        if (PlayerPrefs.GetString("Design") == "B")
        {
            DesignB();
        }

        if (PlayerPrefs.GetString("Design") == "C")
        {
            DesignC();
        }

        if (PlayerPrefs.GetString("Design") == "D")
        {
            DesignD();
        }
    }

    public void DesignA()
    {
        exampleBallon.GetComponent<Image>().sprite = ballonsImg[0];
        exampleBallon2.GetComponent<Image>().sprite = ballonsImg[1];
        exampleCan.GetComponent<Image>().sprite = canPiImg[0];
        exampleCan2.GetComponent<Image>().sprite = canPiImg[1];
        exampleCan3.GetComponent<Image>().sprite = canPiImg[0];
        examplePuan.GetComponent<Image>().sprite = squareRootImg[0];
        endHome.GetComponent<Image>().sprite = rectangleImg[0];

        startbtn.GetComponent<Image>().sprite = rectangleImg[0];
        exitbtn.GetComponent<Image>().sprite = rectangleImg[0];
        designbtn.GetComponent<Image>().sprite = rectangleImg[0];
        detailsbtn.GetComponent<Image>().sprite = rectangleImg[0];

        savebtn.GetComponent<Image>().sprite = rectangleImg[0];
        bactomenu.GetComponent<Image>().sprite = rectangleImg[0];
        deleteusers.GetComponent<Image>().sprite = rectangleImg[0];

        designtext.text = "design changed";
    }

    public void DesignB()
    {
        exampleBallon.GetComponent<Image>().sprite = ballonsImg[2];
        exampleBallon2.GetComponent<Image>().sprite = ballonsImg[3];
        exampleCan.GetComponent<Image>().sprite = canPiImg[2];
        exampleCan2.GetComponent<Image>().sprite = canPiImg[3];
        exampleCan3.GetComponent<Image>().sprite = canPiImg[2];
        examplePuan.GetComponent<Image>().sprite = squareRootImg[2];
        endHome.GetComponent<Image>().sprite = rectangleImg[2];

        startbtn.GetComponent<Image>().sprite = rectangleImg[2];
        exitbtn.GetComponent<Image>().sprite = rectangleImg[2];
        designbtn.GetComponent<Image>().sprite = rectangleImg[2];
        detailsbtn.GetComponent<Image>().sprite = rectangleImg[2];

        savebtn.GetComponent<Image>().sprite = rectangleImg[2];
        bactomenu.GetComponent<Image>().sprite = rectangleImg[2];
        deleteusers.GetComponent<Image>().sprite = rectangleImg[2];

        designtext.text = "design changed";
    }

    public void DesignC()
    {
        exampleBallon.GetComponent<Image>().sprite = ballonsImg[4];
        exampleBallon2.GetComponent<Image>().sprite = ballonsImg[5];
        exampleCan.GetComponent<Image>().sprite = canPiImg[4];
        exampleCan2.GetComponent<Image>().sprite = canPiImg[5];
        exampleCan3.GetComponent<Image>().sprite = canPiImg[4];
        examplePuan.GetComponent<Image>().sprite = squareRootImg[4];
        endHome.GetComponent<Image>().sprite = rectangleImg[4];

        startbtn.GetComponent<Image>().sprite = rectangleImg[4];
        exitbtn.GetComponent<Image>().sprite = rectangleImg[4];
        designbtn.GetComponent<Image>().sprite = rectangleImg[4];
        detailsbtn.GetComponent<Image>().sprite = rectangleImg[4];

        savebtn.GetComponent<Image>().sprite = rectangleImg[4];
        bactomenu.GetComponent<Image>().sprite = rectangleImg[4];
        deleteusers.GetComponent<Image>().sprite = rectangleImg[4];

        designtext.text = "design changed";
    }

    public void DesignD()
    {
        exampleBallon.GetComponent<Image>().sprite = ballonsImg[6];
        exampleBallon2.GetComponent<Image>().sprite = ballonsImg[7];
        exampleCan.GetComponent<Image>().sprite = canPiImg[6];
        exampleCan2.GetComponent<Image>().sprite = canPiImg[7];
        exampleCan3.GetComponent<Image>().sprite = canPiImg[6];
        examplePuan.GetComponent<Image>().sprite = squareRootImg[6];
        endHome.GetComponent<Image>().sprite = rectangleImg[6];

        startbtn.GetComponent<Image>().sprite = rectangleImg[6];
        exitbtn.GetComponent<Image>().sprite = rectangleImg[6];
        designbtn.GetComponent<Image>().sprite = rectangleImg[6];
        detailsbtn.GetComponent<Image>().sprite = rectangleImg[6];

        savebtn.GetComponent<Image>().sprite = rectangleImg[6];
        bactomenu.GetComponent<Image>().sprite = rectangleImg[6];
        deleteusers.GetComponent<Image>().sprite = rectangleImg[6];


        designtext.text = "design changed";
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        designtext.text = "the examples";
    }

    public void DesignMenu()
    {
        designScreen.SetActive(true);
        designScreen.GetComponent<CanvasGroup>().alpha = 1;
        
        menuScreen.GetComponent<CanvasGroup>().alpha = 0;
    }

    public void DetailScreenOpen()
    {
        detailScreen.SetActive(true);
        menuScreen.SetActive(false);
    }

    public void DeleteUsers()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(0);
    }

    public void BackToMenu()
    {
        detailScreen.SetActive(false);
        menuScreen.SetActive(true);
    }

    public void PreferDesignA()
    {
        UserClass.color.Add("A");
        
        UserData.ColorDesign();
    }

    public void PreferDesignB()
    {
        UserClass.color.Add("B");
        UserData.ColorDesign();
    }

    public void PreferDesignC()
    {
        UserClass.color.Add("C");
        UserData.ColorDesign();
    }

    public void PreferDesignD()
    {
        UserClass.color.Add("D");
        UserData.ColorDesign();
    }

}
