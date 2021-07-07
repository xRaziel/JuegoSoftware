using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mostrarmensaje : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D coll){
        if (coll.CompareTag("abuelo")){
            Debug.Log("abuelo esta en el trigger");
        }
    }

    private void OnTriggerExit2D(Collider2D coll){
        if (coll.CompareTag("abuelo")){
            Debug.Log("El abuelo salio del trigger");
        }
    }
}
