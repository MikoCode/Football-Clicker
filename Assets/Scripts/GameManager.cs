using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public float rksPrice, gironaPrice, newcastlePrice, psgPrice;
    public ProgressBar rksBar;
    public float Dollars;
    public float clickValue;
    public float idleValue;
    public float clickUpgradePrice = 100;
    public TextMeshProUGUI DollarsText;
    public TextMeshProUGUI IdleText;
    public TextMeshProUGUI clickUpgradeText;
    private bool startIdle = true;
 
    // Start is called before the first frame update
    void Start()
    {
       
        clickUpgradeText.text = clickUpgradePrice.ToString();
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {

        DollarsText.text = "$ " + Mathf.Round(Dollars);
        IdleText.text = "Idle Value: " + idleValue + "/s";

    }

    public void increasePetro()
    {
        Dollars += clickValue;
    }

  

    public void clickUpgrade()
    {
        Dollars -= clickUpgradePrice;

        
        
            if (clickValue < 4)
            {
                clickValue *= 1.6f;
                clickUpgradePrice *= 1.3f;


            }
          
            else if (clickValue > 4 && clickValue < 100)
            {
                clickValue *= 1.15f;
                clickUpgradePrice *= 1.4f;
            }
            else if (clickValue > 100 && clickValue < 1000)
            {
                clickValue *= 1.07f;
                clickUpgradePrice *= 1.5f;
            }

            else if (clickValue > 1000)
            {
                clickValue *= 1.02f;
                clickUpgradePrice *= 1.6f;
            }

            clickValue = Mathf.Round(clickValue);
            clickUpgradePrice = Mathf.Round(clickUpgradePrice); 

          

            

            clickUpgradeText.text = clickUpgradePrice.ToString();
        
       
    }


    
}
