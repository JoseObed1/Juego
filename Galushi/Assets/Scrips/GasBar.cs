using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GasBar : MonoBehaviour
{
    public Image bar;
    static Image gas;
    public GameObject score;

    public static GameObject score1;

    static float totalGas = 1;

    private void Start()
    {
        score1 = score;
        totalGas = 1;
        gas = bar;
    }

    public static void lifeGas()
    {
        totalGas -= 0.1f;
        gas.fillAmount = totalGas;
        Debug.Log(totalGas);
        if(totalGas <= 0)
        {
            GameOver.Game_Over(score1);
        }
    }
}
