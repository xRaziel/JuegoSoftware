using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{

    
    void Start()
    {
        
    }

    public float speed = 0.03f;
    public float dirX;
    public float dirY;

    void Update()
    {
        dirX = Input.GetAxis("Horizontal");
        dirY = Input.GetAxis("Vertical");
        transform.position += new Vector3(dirX * speed, dirY * speed, 0);
        
    }

    
}
