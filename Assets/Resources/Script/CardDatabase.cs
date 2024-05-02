using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    private void Awake()
    {
        //int ID,string CardName,int Cost,int Ability1_Power,int Ability2_Power,string CardDescription1,string CardDescription2
        //Sprite ThisImage,string Color,int DrawXcards,int AddXmaxMana,int ReturnXcards,
        //int HealXpower,bool Spell,int DamageDealtBySpell
        cardList.Add(new Card(0, "Orino", 1, 2, 0, "Charge(2 Mana):\nDeal 2 Damage to the front Opponent.",
            "Defend(1 Mana):\nNext Damage do to Orino Decreased by 1.",
            Resources.Load<Sprite>("./IMG/Cards/Character/Orino/Orino"), "None", 0, 0, 0, 0, false, 0));

        cardList.Add(new Card(1, "Eyebrowly", 2, 3, 0, "Quick Flame(0 Mana):\nDeal 1 Damage to the front Opponent.",
            "None",
            Resources.Load<Sprite>("./IMG/Cards/Character/Eyebrowly/Eyebrowly"), "None", 0, 0, 0, 0, false, 0));
    }


}
