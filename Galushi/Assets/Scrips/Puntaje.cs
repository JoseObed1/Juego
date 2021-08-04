using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour
{
    public Sprite comboX1;
    public Sprite comboX3;
    public Sprite comboX5;
    public Sprite comboX7;

    private static Sprite C1;
    private static Sprite C3;
    private static Sprite C5;
    private static Sprite C7;


    public static Image spriteFlecha;

    public GameObject flecha;

    public static int puntajeInicial = 0;
    public static int puntajeActual;
    private static int combos = 1;

    public Text marcador;
    // Start is called before the first frame update
    void Start()
    {
        C1 = comboX1;
        C3 = comboX3;
        C5 = comboX5;
        C7 = comboX7;
        spriteFlecha = flecha.GetComponent<Image>();
        puntajeActual = puntajeInicial;
        marcador.text = puntajeInicial.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        marcador.text = puntajeActual.ToString();
    }

    public static void Combo(bool combo, int punto = 1)
    {
        if (combo)
        {
            puntajeActual += punto * combos;
            if (combos < 7)
            {
                combos += 2;
            }
        }
        else if(!combo)
        {
            combos = 1;
        }
        switch (combos)
        {
            case 1:
                spriteFlecha.sprite = C1;
                break;
            case 3:
                spriteFlecha.sprite = C3;
                break;
            case 5:
                spriteFlecha.sprite = C5;
                break;
            case 7:
                spriteFlecha.sprite = C7;
                break;
        }
    }

}
