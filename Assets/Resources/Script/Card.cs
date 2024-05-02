using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card
{
    public int id;
    public string cardName;
    public int cost;//召喚費用
    public int mana;//當前儲存法數量
    public int ability1_power;//技能1消耗法術量
    public int ability2_power;//技能2消耗法數量
    public string ability1_Descrpition;
    public string ability2_Descrpition;

    public int drawXcards;//?
    public int addXmaxMana;//?

    public Sprite thisImage;

    public string color;//?

    public int returnXcards;//?

    public int healXpower;//?

    public bool spell;//?
    public int damageDealtBySpell;//?

    public Card()
    {

    }

    public Card(int ID,string CardName,int Cost,int Ability1_Power,int Ability2_Power,string CardDescription1,string CardDescription2,
        Sprite ThisImage,string Color,int DrawXcards,int AddXmaxMana,int ReturnXcards,
        int HealXpower,bool Spell,int DamageDealtBySpell)
    {
        id = ID;
        cardName = CardName;
        cost = Cost;
        ability1_power = Ability1_Power;
        ability2_power = Ability2_Power;
        ability1_Descrpition = CardDescription1;
        ability2_Descrpition = CardDescription2;
        thisImage = ThisImage;
        color = Color;
        drawXcards = DrawXcards;
        addXmaxMana = AddXmaxMana;
        returnXcards = ReturnXcards;
        healXpower = HealXpower;
        spell = Spell;
        damageDealtBySpell = DamageDealtBySpell;




    }


}
