using System;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
    [SerializeField] private int money = 0;
    [SerializeField] private GameObject girlPlayer;
    [SerializeField] private bool isGirlEnable = true;

    public void IncreaseMoney()
    {
        money += 200;
    }

    public void DecreaseRingAmount()
    {
        if (money >= 500)
        {
            money -= 500;
        }
        else
        {
            Debug.Log("Love Decrease -50");
        }
    }

    private void Update()
    {
        GirlStatus();
    }

    public void GirlStatus()
    {
        if (isGirlEnable)
        {
            girlPlayer.SetActive(true);
        }
        else
        {
            girlPlayer.SetActive(false);
        }
    }

    public void GirlEnableTrue()
    {
        isGirlEnable = true;
    }

    public void GirlEnableFalse()
    {
        isGirlEnable = false;
    }
}