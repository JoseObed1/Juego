using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Clonarglobos3 : MonoBehaviour
{
    public GameObject globo;
    public GameObject globo1;
    public GameObject globo2;
    public GameObject globo3;

    private static GameObject[] gObject = new GameObject[4];

    public GameObject lanzador;
    private static Transform position;

    private void Start()
    {
        gObject[0] = globo;
        gObject[1] = globo1;
        gObject[2] = globo2;
        gObject[3] = globo3;
        position = lanzador.gameObject.transform;
    }


    public static void Clonar(int globo)
    {
        Instantiate(gObject[globo], position.position, Quaternion.identity);
    }
}
