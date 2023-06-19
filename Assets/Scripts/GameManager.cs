using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;


public class GameManager : MonoBehaviour
{
    public Text sayisoru1,sayisoru2;
    public GameObject panel,butonlar;
    public Transform butonPanel,sorupanel;

    Vector3 hedef;
    Vector3 Konum;
    Vector3 baslangickonum;

    int sayi1, sayi2, deger,cevap,tickValues,can;
    int seviye;
    public float hiz;
  
    bool isAnswer=true;
    
    
    GameObject[] cevaplar = new GameObject[5];
    List<int> cevaplarlist = new List<int>();

    CanPi canPi;
    PuanKontrol puanKontrol;
    LevelManager levelManager;
    private void Awake()
    {
        
        canPi = Object.FindObjectOfType<CanPi>();
        puanKontrol = Object.FindObjectOfType<PuanKontrol>();
        levelManager = Object.FindObjectOfType<LevelManager>();
        can = 3;
        canPi.CanlariKontrolEt(can);
        
    }

    private void Start()
    {
        CevaplariOlustur();
        
    }

    void Update()
    {
        seviye = levelManager.level;
        
        hiz = 0.3f + (0.17f * seviye);

        DOTween.SetTweensCapacity(10000, 1100);
       
        baslangickonum = new Vector3(0, 4, 100);
        Konum = panel.GetComponent<RectTransform>().position;
        hedef = new Vector3(baslangickonum.x, -2f, baslangickonum.z);
        
        if (Konum.y > hedef.y)
        {
            SoruyuIndir();

        }

        if (Konum.y <= (hedef.y + 1f) || (1f + Konum.y) == hedef.y)
        {
            SoruyuBasaAl();
            
            can--;
            canPi.CanlariKontrolEt(can);
            isAnswer = true;
        }

       // if (isAnswer)
    //    {
            
         //   isAnswer = false;
           /// cevaplarlist.Clear();
          //  CevaplariYazdir();

       // }

    }
    
    public void CevaplariOlustur()
    {
        
        for(int i = 0; i < 5; i++)
        {

            
            GameObject btn = Instantiate(butonlar, butonPanel);
            btn.transform.GetComponent<Button>().onClick.AddListener(() => Butonclick());

            cevaplar[i] = btn;
            Debug.Log("bitti");
        }
        CevaplariYazdir();
        


    }
    void Butonclick()
    {
        
        tickValues =int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.transform.GetChild(0).GetComponent<Text>().text);
        if (tickValues == cevap)
        {
            puanKontrol.PuanSayac(seviye);
            cevaplarlist.Clear();
            CevaplariYazdir();
            
            SoruyuBasaAl();
           
        }
        else
        {
            can--;
            canPi.CanlariKontrolEt(can);
        }
    }
   
    int aralýk1 = 16;
    int aralýk2 = 32;
    int aralýk3 = 3;
    int aralýk4 = 14;

    

    public void CevaplariYazdir()
    {
        
        
       foreach (var btn in cevaplar)
       {
            int rastgelesayi = Random.Range(aralýk1, aralýk2);
            cevaplarlist.Add(rastgelesayi);
            btn.transform.GetChild(0).GetComponent<Text>().text = rastgelesayi.ToString();
            aralýk1++;
            aralýk2++;
       }
       SoruyuOlustur();

    }
    public void SoruyuOlustur()
    {
       


        sayi1 = Random.Range(aralýk3, aralýk4);
        
    
        deger = Random.Range(0, cevaplarlist.Count);
        
        sayi2 = cevaplarlist[deger]-sayi1;
        
        cevap = sayi1 + sayi2;
        
        sayisoru1.text = sayi1.ToString();
        sayisoru2.text = sayi2.ToString();
       

        aralýk3++;
        aralýk4++;
    }

    public void SoruyuIndir()
    {
        panel.GetComponent<RectTransform>().position = Vector3.MoveTowards(Konum, hedef, hiz * Time.deltaTime);
       
    }

    public void SoruyuBasaAl()
    {
        panel.GetComponent<RectTransform>().position = baslangickonum;
       
    }

}
