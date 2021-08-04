using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borde : MonoBehaviour
{
    public GameObject nave;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Alien")
        {
            Renderer render = GetComponent<Renderer>();
            render.material.color = Color.green;
            Destroy(nave);
            GameOver.Game_Over(GasBar.score1);
        }

    }
}
