﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void escenaJuego(){
        SceneManager.LoadScene("Juego");
    }

    public void escenaIntrucciones()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void escenaMenu(){
        SceneManager.LoadScene("Mainmenu");
    }




}
