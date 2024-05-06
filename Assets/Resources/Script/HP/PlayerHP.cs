using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public static float maxHP;
    public static float staticHP;
    public float HP;
    public Image Health;
    public Text HP_Text;

    void Start()
    {
        maxHP = 20;
        staticHP = maxHP;
    }

    private void Update()
    {
        HP = staticHP;
        Health.fillAmount = HP / maxHP;

        HP = Mathf.Min(HP, maxHP);

        HP_Text.text = "" + HP;


    }

}
