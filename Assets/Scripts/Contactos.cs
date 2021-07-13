using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contactos : MonoBehaviour
{
    public GameObject listaContactos;
    public Mochila m;

    public void listaContactosPanel()
    {
        bool cellInMochila = false;
        m = FindObjectOfType<Mochila>();
        for (int i = 0; i < m.Bag.Count; i++)
        {
            if (m.Bag[i].GetComponent<Image>().sprite.name.Equals("SpriteSheet_0"))
            {
                Debug.Log("esta entrando al if ");
                cellInMochila = true;
                break;
            }
        }
        if (cellInMochila)
        {
            Time.timeScale = 0;
            listaContactos.SetActive(true);
        }

    }
    public void Return()
    {
        Time.timeScale = 1;
        listaContactos.SetActive(false);
    }
}
