using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCard : MonoBehaviour
{

    //public List<Card> displayCard = new List<Card>();
    public int displayID = 0;

    public int id;
    public string cardName;
    public int cost;//召喚費用
    public int mana;//當前儲存法數量
    public int ability1_power;//技能1消耗法術量
    public int ability2_power;//技能2消耗法數量
    public string ability1_Descrpition;
    public string ability2_Descrpition;

    public Text nameText;
    public Text costText;
    public Text ability1_Text;
    public Text ability2_Text;

    public Image thisImage;
    public Image artImage;

    public bool cardBack;//卡背是否啟用
    public GameObject cardBackObject;
    //public static bool staticCardBack;//卡背是否啟用 static ，以供全域使用，不須一直尋找並抓取該物件


    void Start()
    {
        DisplayCardInfo();


        //displayCard[0] = CardDatabase.cardList[displayID];

        //id = displayCard[0].id;
        //cardName = displayCard[0].cardName;
        //cost = displayCard[0].cost;
        //ability1_power = displayCard[0].ability1_power;
        //ability2_power = displayCard[0].ability2_power;
        //ability1_Descrpition = displayCard[0].ability1_Descrpition;
        //ability2_Descrpition = displayCard[0].ability2_Descrpition;

        //nameText.text = "" + cardName;
        //costText.text = "" + cost;
        //ability1_Text.text = "" + ability1_Descrpition;
        //ability2_Text.text = "" + ability2_Descrpition;
        //artImage.sprite = displayCard[0].thisImage;
    }
    void DisplayCardInfo()
    {
        if (displayID <= CardDatabase.cardList.Count) //displayID 並未超出index
        {
            Card card = CardDatabase.cardList[displayID];

            nameText.text = "" + card.cardName;
            costText.text = "" + card.cost;
            if (card.ability1_Descrpition != "")//若有技能
                ability1_Text.text = "" + card.ability1_Descrpition + "\n (Power: " + card.ability1_power + ")";
            else
                ability1_Text.text = "";

            if (card.ability2_Descrpition != "")//若有技能
                ability2_Text.text = "" + card.ability2_Descrpition + "\n (Power: " + card.ability2_power + ")";
            else
                ability2_Text.text = "";
            //thisImage = 
            artImage.sprite = Resources.Load<Sprite>(card.imagePath);
        }
        else
        {
            Debug.LogError("Card ID out of range: " + displayID);
        }
    }

    void Update()
    {
        if (cardBack)
            cardBackObject.SetActive(true);
        else
            cardBackObject.SetActive(false);
        //staticCardBack = cardBack;
        //if (cardBack != staticCardBack)
        //{ 
        //    staticCardBack = cardBack;
        //    Debug.Log("staticCardBack updated to: " + staticCardBack);
        //}

    }
}
