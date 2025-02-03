using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCard : MonoBehaviour
{

    //public List<Card> displayCard = new List<Card>();
    public Card displayCard = new Card();
    public int displayID = 0;//id-1

    public int id;
    public string cardName;
    public int cost;//�l��O��
    public int mana;//��e�x�s�k�ƶq
    public int ability1_power;//�ޯ�1���Ӫk�N�q
    public int ability2_power;//�ޯ�2���Ӫk�ƶq
    public string ability1_Descrpition;
    public string ability2_Descrpition;

    public Text nameText;
    public Text costText;
    public Text ability1_Text;
    public Text ability2_Text;

    public Image thisImage;
    public Image artImage;

    public bool cardBack;//�d�I�O�_�ҥ�
    public GameObject cardBackObject;

    public GameObject Hand;
    public int numberOfCardsInDeck;


    void Start()
    {

        Hand = GameObject.Find("MyHands");

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
        if (displayID <= CardDatabase.cardList.Count) //displayID �å��W�Xindex
        {
            numberOfCardsInDeck = PlayerDeck.deckSize;

            displayCard = CardDatabase.cardList[displayID];
            nameText.text = "" + displayCard.cardName;
            costText.text = "" + displayCard.cost;
            if (displayCard.ability1_Descrpition != "")//�Y���ޯ�
                ability1_Text.text = "" + displayCard.ability1_Descrpition + "\n (Power: " + displayCard.ability1_power + ")";
            else
                ability1_Text.text = "";

            if (displayCard.ability2_Descrpition != "")//�Y���ޯ�
                ability2_Text.text = "" + displayCard.ability2_Descrpition + "\n (Power: " + displayCard.ability2_power + ")";
            else
                ability2_Text.text = "";
            //thisImage = 
            artImage.sprite = Resources.Load<Sprite>(displayCard.imagePath);
        }
        else
        {
            Debug.LogError("Card ID out of range: " + displayID);
        }
    }

    void Update()
    {
        if (this.transform.parent == Hand.transform.parent)
        {
            cardBack = false;
        }

        if(CompareTag("Clone"))
        {
            displayID = PlayerDeck.staticDeck[numberOfCardsInDeck - 1].id -1;
            numberOfCardsInDeck--;
            PlayerDeck.deckSize--;
            cardBack = false;
            this.tag = "Untagged";
            Debug.Log("deckSize" + PlayerDeck.deckSize);
        }

        DisplayCardInfo();

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
