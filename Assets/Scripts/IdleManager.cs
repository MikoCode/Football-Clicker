using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IdleManager : MonoBehaviour
{
    public float RKSProfit, GironaProfit, NewcastleProfit, PSGProfit;
    public FillSlider rksSlider, gironaSlider, newcastleSlider, psgSlider;
    public TextMeshProUGUI rksButtonText, gironaButtonText, newcastleButtonText, psgButtonText;
    public float rksRate, gironaRate, newcastleRate, psgRate;
    public bool rksStarted, gironaStarted, newcastleStarted, psgStarted;
    public Image rksImage, gironaImage, newcastleImage, psgImage;
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        GameManager.Instance.idleValue = (RKSProfit) + (GironaProfit/5) + (NewcastleProfit/12) + (PSGProfit/20);
    }


    public void RKS()
    {
       
        GameManager.Instance.Dollars += RKSProfit;
    }
    public void IncreaseRKS()
    {
        if(rksStarted == false)
        {
            InvokeRepeating("RKS", 0, 1);
            rksSlider.StartFilling(1);
            rksImage.color = new Color(1, 1, 1, 1);

        }
        GameManager.Instance.Dollars -= GameManager.Instance.rksPrice;
        GameManager.Instance.rksPrice *= 1.2f;
        rksStarted = true;
        rksButtonText.text = Mathf.Round(GameManager.Instance.rksPrice) + "$";
        RKSProfit *= rksRate;

    }

    public void Girona()
    {
        GameManager.Instance.Dollars += GironaProfit;
    }
    public void IncreaseGirona()
    {
        if(gironaStarted == false)
        {
            InvokeRepeating("Girona", 0, 5);
            gironaSlider.StartFilling(1);
            gironaImage.color = new Color(1, 1, 1, 1);
        }
        GameManager.Instance.Dollars -= GameManager.Instance.gironaPrice;
        GameManager.Instance.gironaPrice *= 1.2f;
        gironaStarted = true;
        gironaButtonText.text = Mathf.Round(GameManager.Instance.gironaPrice) + "$";
        GironaProfit *= gironaRate;
    }

    public void Newcastle()
    {
        GameManager.Instance.Dollars += NewcastleProfit;
    }
    public void IncreaseNewcastle()
    {
        if(newcastleStarted == false)
        {
            InvokeRepeating("Newcastle", 0, 12);
            newcastleSlider.StartFilling(1);
            newcastleImage.color = new Color(1, 1, 1, 1);
        }
        GameManager.Instance.Dollars -= GameManager.Instance.newcastlePrice;
        GameManager.Instance.newcastlePrice *= 1.3f;
        newcastleStarted = true;
        newcastleButtonText.text = Mathf.Round(GameManager.Instance.newcastlePrice) + "$";
        NewcastleProfit *= newcastleRate;
       
    }

    public void PSG()
    {
        GameManager.Instance.Dollars += PSGProfit;
    }
    public void IncreasePSG()
    {
        if(psgStarted== false)
        {
            InvokeRepeating("PSG", 0, 20);
            psgImage.color = new Color(1, 1, 1, 1);
        }

        GameManager.Instance.Dollars -= GameManager.Instance.psgPrice;
        GameManager.Instance.psgPrice *= 1.4f;
        psgStarted = true;
        psgButtonText.text = Mathf.Round(GameManager.Instance.psgPrice) + "$";
      
        PSGProfit *= psgRate;
    }
}
