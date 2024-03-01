using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Button upgradeClick;
    public Button rksButton, gironaButton, newcastleButton, psgButton;
 
  

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        showClickUpgrade();
        showRKSUpgrade();
        showGironaUpgrade();
        showPsgUpgrade();
        showNewcastleUpgrade(); 
    }


    private void showClickUpgrade()
    {
        if (GameManager.Instance.Dollars >= GameManager.Instance.clickUpgradePrice)
        {
            upgradeClick.enabled = true;
            upgradeClick.image.color = Color.white;
        }
        else if (GameManager.Instance.Dollars < GameManager.Instance.clickUpgradePrice)
        {
            upgradeClick.enabled = false;
            upgradeClick.image.color = Color.gray;
            

        }
    }

    private void showRKSUpgrade()
    {
        if(GameManager.Instance.Dollars >= GameManager.Instance.rksPrice)
        {
            rksButton.enabled = true;
            rksButton.image.color = Color.white;
        }
        else
        {
            rksButton.enabled = false;
            rksButton.image.color = Color.gray;
        }
    }

    private void showGironaUpgrade()
    {
        if (GameManager.Instance.Dollars >= GameManager.Instance.gironaPrice)
        {
            gironaButton.enabled = true;
            gironaButton.image.color = Color.white;
        }
        else
        {
            gironaButton.enabled = false;
            gironaButton.image.color = Color.gray;
        }
    }

    private void showNewcastleUpgrade()
    {
        if (GameManager.Instance.Dollars >= GameManager.Instance.newcastlePrice)
        {
            newcastleButton.enabled = true;
            newcastleButton.image.color = Color.white;
        }
        else
        {
            newcastleButton.enabled = false;
            newcastleButton.image.color = Color.gray;
        }
    }

    private void showPsgUpgrade()
    {
        if (GameManager.Instance.Dollars >= GameManager.Instance.psgPrice)
        {
            psgButton.enabled = true;
            psgButton.image.color = Color.white;
        }
        else
        {
            psgButton.enabled = false;
            psgButton.image.color = Color.gray;
        }
    }
}
