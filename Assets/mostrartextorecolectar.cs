using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mostrartextorecolectar : MonoBehaviour
{
    // Start is called before the first frame update
    public Text textorecolectar;
    void Start()
    {
        textorecolectar.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("abuelo")){
            textorecolectar.gameObject.SetActive(true);
        }
    }

    private void OntriggerExit2D(Collider2D coll){
        if (coll.CompareTag("abuelo")){
            textorecolectar.gameObject.SetActive(false);
        }
    }


}
