using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzarNG : MonoBehaviour
{
    private int time;
    private int lastValue;
    // Update is called once per frame
    void Update()
    {
        time += 1;
        if(time == 120)
        {
            time = 0;
            Debug.Log("Lance un globo");
            int val = Random.Range(1, 4);
            while (lastValue == val)
            {
                val = Random.Range(1, 4);
            }
            lastValue = val;
            LanzarGlobo(val, Random.Range(0, 4));
        }
    }
    void LanzarGlobo(int posision, int globo)
    {
        Debug.Log(posision);
        switch (posision)
        {
            case 1:
                Clonarglobos.Clonar(globo);
                break;
            case 2:
                Clonarglobos2.Clonar(globo);
                break;
            case 3:
                Clonarglobos3.Clonar(globo);
                break;
            case 4:
                Clonarglobos4.Clonar(globo);
                break;
        }
                
    }
}
