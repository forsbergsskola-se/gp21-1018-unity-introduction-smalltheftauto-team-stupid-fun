using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Currency : MonoBehaviour
{
    public int currentMoney;
    
    void Start()
    {
        currentMoney = 50;
    }

    
    void Update()
    {
        
    }
    
    public void GainMoney(int moneyToGain)
    {
        currentMoney += moneyToGain;
    }

    public void LoseMoney(int moneyToLose)
    {
        currentMoney /= 2;
    }

    public void SpendMoney(int moneyToSpend)
    {
        if (currentMoney - moneyToSpend < 0)
        {
            Debug.Log("I dont have enough money...");
        }
        currentMoney -= moneyToSpend;
    }
}
