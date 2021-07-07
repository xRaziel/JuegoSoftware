using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlmensajes : MonoBehaviour
{
    // Start is called before the first frame update
    public float mostrarintruccionmovimiento;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mostrarintruccionmovimiento -= Time.deltaTime;
        if (mostrarintruccionmovimiento <= 0){
            Destroy(this.gameObject);
        }
    }




}
