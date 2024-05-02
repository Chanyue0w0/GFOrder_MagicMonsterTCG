using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card2 card;

    public Text nameText;
    

    public Text manaText;
    public Text description1_Text;
    public Text description2_Text;

    //public Text ability1_Text;
    //public Text ability2_Text;

    void Start()
    {
        nameText.text = card.name;
        description1_Text.text = card.description1;
        description2_Text.text = card.description2;

        manaText.text = card.manaCost.ToString();
        //ability1_Text.text = 

    }

    
}
