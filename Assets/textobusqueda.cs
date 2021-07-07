using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textobusqueda : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    private void OnTriggerEnter2D(Collider2D coll){
        if  (coll.CompareTag("abuelo")){
            gameObject.SetActive(false);
        }
    }

}
