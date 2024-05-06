using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHP : MonoBehaviour
{
    public static float maxHP2;
    public static float staticHP2;
    public float HP2;
    public Image Health;
    public Text HP_Text;

    void Start()
    {
        maxHP2 = 20;
        staticHP2 = maxHP2;
    }

    private void Update()
    {
        HP2 = staticHP2;
        Health.fillAmount = HP2 / maxHP2;

        HP2 = Mathf.Min(HP2, maxHP2);

        HP_Text.text = "" + HP2;


    }
}
