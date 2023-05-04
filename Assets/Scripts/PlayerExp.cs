using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerExp : MonoBehaviour
{
    public int exp;
    public int currentLevel;

    public ExpBar expBar;
    public TMP_Text level;

    public void AddExp(int expToAdd)
    {
        this.exp += expToAdd;

        expBar.SetExp(exp);

        int expToNextLevel = 20;

        if (exp >= expToNextLevel)
        {
            this.exp = 0;
            this.currentLevel++;
            level.text = currentLevel.ToString();
            Debug.Log("Next level reached");
        }
    }
}
