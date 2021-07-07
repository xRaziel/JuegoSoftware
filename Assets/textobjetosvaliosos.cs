using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textobjetosvaliosos : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject texto;
    void Start()
    {
        texto.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D coll){
        if  (coll.CompareTag("abuelo")){
            gameObject.SetActive(true);
        }
    }

}
