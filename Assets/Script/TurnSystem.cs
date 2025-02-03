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

    //�ۨ��]�O�A���]�O��10
    public int maxMana;
    public int currentMana;
    public Text myManaText;

    //����]�O�A���]�O��10
    public int maxMana2;
    public int currentMana2;
    public Text enemyManaText;

    public static bool startTurn;//�^�X�}�l (�i�Ω�ޯ�,�^�X�p��)



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
        if (isYourTurn)//�������a�^�X�A������
        {
            isYourTurn = false;
            oppenentTurn += 2;
            maxMana2 = Mathf.Min(10, maxMana2 + 2);
            currentMana2 = maxMana2;
        }
        else//�������^�X�A���쪱�a
        {
            isYourTurn = true;
            yourTurn += 2;
            maxMana = Mathf.Min(10, maxMana + 2);
            currentMana = maxMana;

            startTurn = true;
        }


    }



}
