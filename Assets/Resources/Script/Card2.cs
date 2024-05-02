using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card",menuName = "Card")]

public class Card2 : ScriptableObject
{
    public new string name;
    public string description1;
    public string description2;
    public int manaCost;
    public int ability1_mana;
    public int ability2_mana;

    public void Print()
    {
        Debug.Log(name + ": " + description1 + "\n" + description2 + "The card costs: " + manaCost);
    }

}
