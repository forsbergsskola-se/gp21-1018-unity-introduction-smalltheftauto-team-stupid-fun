using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Currency : MonoBehaviour
{
    public int currentMoney;
    public TMPro.TextMeshProUGUI moneyText;
    
    void Start()
    {
        currentMoney = 50;
        moneyText.text = currentMoney.ToString() + "$";
    }

    
    void Update()
    {
        
    }
    
    public void GainMoney(int moneyToGain)
    {
        currentMoney += moneyToGain;
        moneyText.text = currentMoney.ToString() + "$";
    }

    public void LoseMoney()
    {
        currentMoney /= 2;
        moneyText.text = currentMoney.ToString() + "$";
    }

    public void SpendMoney(int moneyToSpend)
    {
        if (currentMoney - moneyToSpend < 0)
        {
            Debug.Log("I dont have enough money...");
        }
        else
        {
            currentMoney -= moneyToSpend;
            moneyText.text = currentMoney.ToString() + "$";  
        }
    }
}
