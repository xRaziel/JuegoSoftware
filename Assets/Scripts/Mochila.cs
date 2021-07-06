using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mochila : MonoBehaviour
{
    public List<GameObject> Bag = new List<GameObject>();
    public GameObject inv;
    public bool activarInv;
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Item") || coll.CompareTag("Cell"))
        {
            
            for (int i = 0; i < Bag.Count; i++)
            {
                if (Bag[i].GetComponent<Image>().enabled == false)
                {
                    Debug.Log("Esta pasando");
                    Bag[i].GetComponent<Image>().enabled = true;
                    Bag[i].GetComponent<Image>().sprite = coll.GetComponent<SpriteRenderer>().sprite;
                    coll.gameObject.SetActive(false);
                    break;

                }
            }
        }
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
    }
}
