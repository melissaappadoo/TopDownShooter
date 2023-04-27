using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExp : MonoBehaviour
{
    public int exp;
    private int currentLevel;

    public ExpBar expBar;

    public void AddExp(int expToAdd)
    {
        this.exp += expToAdd;

        expBar.SetExp(exp);

        int expToNextLevel = 20;

        if (exp >= expToNextLevel)
        {
            this.exp = 0;
            this.currentLevel++;
            Debug.Log("Next level reached");
        }
    }
}
