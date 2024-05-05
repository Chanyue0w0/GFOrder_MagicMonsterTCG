using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>(); //static 

    void Awake()
    {
        TextAsset textAsset = Resources.Load<TextAsset>("json/Cards");
        if (textAsset != null)
        {
            string dataAsJson = textAsset.text;
            CardContainer container = JsonUtility.FromJson<CardContainer>(dataAsJson);
            foreach (Card card in container.cardList)
            {
                //card.LoadSprite(); // ¥[¸ü¹Ï¤ù
                cardList.Add(card);
            }
        }
        else
        {
            Debug.LogError("Cannot find Cards.json in Resources folder");
        }
        //cardList.Add(new Card(0, "Orino", 1, 2, 0,
        //    "Charge(2 Mana):\nDeal 2 Damage to the front Opponent.",
        //    "Defend(1 Mana):\nNext Damage do to Orino Decreased by 1.",
        //    Resources.Load<Sprite>("IMG/Cards/Character/Orino/Orino"),
        //    "None", 0, 0, 0, 0, false, 0));

        //cardList.Add(new Card(1, "Eyebrowly", 2, 3, 0,
        //    "Quick Flame(0 Mana):\nDeal 1 Damage to the front Opponent.",
        //    "",
        //    Resources.Load<Sprite>("IMG/Cards/Character/Eyebrowly/Eyebrowly"),
        //    "None", 0, 0, 0, 0, false, 0));

        //cardList.Add(new Card(2, "WinniDuck", 3, 3, 0,
        //    "Water skiing(3 Mana):\nDraw 2 cards",
        //    "",
        //    Resources.Load<Sprite>("IMG/Cards/Character/WinniDuck/WinniDuck1"),
        //    "None", 0, 0, 0, 0, false, 0));

        //cardList.Add(new Card(3, "Mouthly", 2, 4, 0,
        //    "Bite(1 Mana):\nDeal 2 Damage to the front Opponent.",
        //    "Evolve(5 Mana):\nFind Mouthest in the deck and Evolve this card to Mouthest",
        //    Resources.Load<Sprite>("IMG/Cards/Character/Mouthly/Mouthly1"),
        //    "None", 0, 0, 0, 0, false, 0));


    }


}
