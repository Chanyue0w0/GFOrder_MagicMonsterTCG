using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnSystem : MonoBehaviour
{
    public bool isYourTurn;
    public int yourTurn;
    public int oppenentTurn;
    public Text turnText;

    //自身魔力，滿魔力值10
    public int maxMana;
    public int currentMana;
    public Text myManaText;

    //對手魔力，滿魔力值10
    public int maxMana2;
    public int currentMana2;
    public Text enemyManaText;

    public static bool startTurn;//回合開始 (可用於技能,回合計算)



    void Start()
    {
        isYourTurn = true;
        yourTurn = 1;
        oppenentTurn = 2;

        maxMana = 1;
        currentMana = 1;

        maxMana2 = 0;
        currentMana2 = 0;

        startTurn = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (isYourTurn)
        {
            turnText.text = "Is Your Turn";
        }
        else
        {
            turnText.text = "Is Oppenent Turn";
        }
        myManaText.text = currentMana + "/" + maxMana;
        enemyManaText.text = currentMana2 + "/" + maxMana2;
    }

    public void EndTurn()
    {
        if (isYourTurn)//結束玩家回合，輪到對手
        {
            isYourTurn = false;
            oppenentTurn += 2;
            maxMana2 = Mathf.Min(10, maxMana2 + 2);
            currentMana2 = maxMana2;
        }
        else//結束對手回合，輪到玩家
        {
            isYourTurn = true;
            yourTurn += 2;
            maxMana = Mathf.Min(10, maxMana + 2);
            currentMana = maxMana;

            startTurn = true;
        }


    }



}
