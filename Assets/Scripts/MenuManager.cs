using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class MenuManager : MonoBehaviour
{

    public InputField showUsername;
    private void Start()
    {
        transform.GetComponent<CanvasGroup>().DOFade(1, 0.7f);
        
        showUsername.text = PlayerPrefs.GetString("Username1");
        
    }
}
