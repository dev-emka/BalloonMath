using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuDisagn : MonoBehaviour
{
    public InputField userName;
    public Text score1,score2,score3,score4,datetime,datetime1,datetime2,datetime3;
    
    private void Start()
    {
        UserClass.scores[1] = PlayerPrefs.GetInt("Scores4");
        UserClass.scores[2] = PlayerPrefs.GetInt("Scores3");
        UserClass.scores[3] = PlayerPrefs.GetInt("Scores2");
        UserClass.scores[4] = PlayerPrefs.GetInt("Scores1");

        UserClass.color[UserClass.color.Count - 1] = PlayerPrefs.GetString("Design");

        UserData.ColorDesign();

        Debug.Log(PlayerPrefs.GetString("Design"));

        NowTime.times[1] = PlayerPrefs.GetString("Time1");
        NowTime.times[2] = PlayerPrefs.GetString("Time2");
        NowTime.times[3] = PlayerPrefs.GetString("Time3");
        NowTime.times[4] = PlayerPrefs.GetString("Time4");

        userName.text = PlayerPrefs.GetString("Username1");


        score1.text = PlayerPrefs.GetInt("Scores1").ToString();
        score2.text = PlayerPrefs.GetInt("Scores2").ToString();
        score3.text = PlayerPrefs.GetInt("Scores3").ToString();
        score4.text = PlayerPrefs.GetInt("Scores4").ToString();


        datetime.text = PlayerPrefs.GetString("Time1");
        datetime1.text = PlayerPrefs.GetString("Time2");
        datetime2.text = PlayerPrefs.GetString("Time3");
        datetime3.text = PlayerPrefs.GetString("Time4");

    }
}
