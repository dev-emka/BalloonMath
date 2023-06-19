using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class UserDataChang : MonoBehaviour
{
    public InputField userNameTxt;
    
    public GameObject startScreen,menuScreen,image1,image2,image3,image4;
    private void Start()
    {
        
        image1.GetComponent<Image>().fillAmount = PlayerPrefs.GetInt("Scores1") / 1000f;
        image2.GetComponent<Image>().fillAmount = PlayerPrefs.GetInt("Scores2") / 1000f;
        image3.GetComponent<Image>().fillAmount = PlayerPrefs.GetInt("Scores3") / 1000f;
        image4.GetComponent<Image>().fillAmount = PlayerPrefs.GetInt("Scores4") / 1000f;
        
        
        
        CheckedWhenStart();
    }

    public void Saved()
    {
        UserClass.userName = userNameTxt.text;
        UserData.SaveUsers();
        
        
        CheckedWhenStart();
    }

    public void Load()
    {

        
    }

    public void CheckedWhenStart()
    {
        if (PlayerPrefs.HasKey("Username1"))
        {
            startScreen.SetActive(false);
            menuScreen.SetActive(true);
        }
        else
        {
            startScreen.SetActive(true);
            menuScreen.SetActive(false);
        }
        
    }
}
