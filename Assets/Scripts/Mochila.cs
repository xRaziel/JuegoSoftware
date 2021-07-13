using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mochila : MonoBehaviour
{
    public List<GameObject> Bag = new List<GameObject>();
    public GameObject inv;
    public bool activarInv;
    public GameObject listaContactos;

    public GameObject text;
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Item") || coll.CompareTag("Cell"))
        {
            
            for (int i = 0; i < Bag.Count; i++)
            {
                if (Bag[i].GetComponent<Image>().enabled == false)
                {
                    Bag[i].GetComponent<Image>().enabled = true;
                    Bag[i].GetComponent<Image>().sprite = coll.GetComponent<SpriteRenderer>().sprite;
                    coll.gameObject.SetActive(false);
                    break;

                }
            }
        
        }

        
    }

    public List<GameObject> getBag()
    {
        return Bag;
    }



    // Update is called once per frame
    void Update()
    {
        if (activarInv)
        {
            inv.SetActive(true);
        }
        else
        {
            inv.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            activarInv = !activarInv;
        }

        
        if (Bag.Count > 0){
            text.SetActive(true);
        }
        else{
            text.SetActive(false);
        }
        
    }

    public void listaContactosPanel()
    {
        bool celularInMochila = false;
        for(int i = 0; i < Bag.Count; i++)
        {
            if(Bag[i].GetComponent<Image>().CompareTag("Cell"))
            {
                celularInMochila = true;
                break;
            }
        }
        if (celularInMochila)
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
