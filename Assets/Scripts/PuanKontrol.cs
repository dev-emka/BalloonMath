using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuanKontrol : MonoBehaviour
{
    
    public int toplamPuan;
    int puanArtisi;
    [SerializeField]
    private Text PuanTxt;

    [SerializeField]
    private Text PuanTxt2;

    private void Start()
    {
        PuanTxt.text = toplamPuan.ToString();
        toplamPuan = 0;
    }
    public void PuanSayac(int Level)
    {
        puanArtisi = 10;

        toplamPuan += puanArtisi;
        
        
        PuanTxt.text = toplamPuan.ToString();
        PuanTxt2.text = toplamPuan.ToString();
    }
}
