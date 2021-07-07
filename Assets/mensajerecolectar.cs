using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mensajerecolectar : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject textoinstruccion;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void  OnTriggerEnter2D(Collider2D cuerpo){
        if (cuerpo.tag == "abuelo"){
            mostrartexto();
        }
    }

    private void OntriggerExit2D(Collider2D cuerpo){
        Destroy(GameObject.Find(textoinstruccion.name+"(Clone)"));
        Destroy(GameObject.FindWithTag("texto"));
    }

    void mostrartexto(){
        GameObject texto = Instantiate(textoinstruccion);
        texto.transform.position = new Vector3(this.gameObject.transform.position.x,this.gameObject.transform.position.y,this.gameObject.transform.position.z);
    }
    

}
