using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserData : MonoBehaviour
{
    public static void SaveUsers()
    {
        PlayerPrefs.SetString("Username1", UserClass.userName);
    }

    public static void SaveScores()
    {
        PlayerPrefs.SetInt("Scores1", UserClass.scores[UserClass.scores.Count - 1]);

        PlayerPrefs.SetString("Time1", NowTime.times[NowTime.times.Count-1]);


        PlayerPrefs.SetInt("Scores2", UserClass.scores[UserClass.scores.Count - 2]);

        PlayerPrefs.SetString("Time2", NowTime.times[NowTime.times.Count - 2]);


        PlayerPrefs.SetInt("Scores3", UserClass.scores[UserClass.scores.Count - 3]);

        PlayerPrefs.SetString("Time3", NowTime.times[NowTime.times.Count - 3]);


        PlayerPrefs.SetInt("Scores4", UserClass.scores[UserClass.scores.Count - 4]);

        PlayerPrefs.SetString("Time4", NowTime.times[NowTime.times.Count - 4]);

    }

    public static void ColorDesign()
    {
        PlayerPrefs.SetString("Design", UserClass.color[UserClass.color.Count-1]);
    }

   

}
