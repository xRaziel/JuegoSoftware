using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class evacSign : MonoBehaviour
{
    public GameObject signMessage;
    public GameObject signWarning;
    public string signDirection;
    private float vertical;
    private float horizontal;
    public Text message;
    // Start is called before the first frame update
    void Start()
    {
        vertical = 0;
        horizontal = 0;
        signMessage.SetActive(false);
        signWarning.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        vertical = GameObject.FindWithTag("abuelo").GetComponent<Jugador>().dirY;
        horizontal = GameObject.FindWithTag("abuelo").GetComponent<Jugador>().dirX;
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "abuelo")
        {
            switch (signDirection)
            {
                case "left":
                    message.text = "La salida de emergencia se encuentra hacia la izquierda.";
                    break;
                case "right":
                    message.text = "La salida de emergencia se encuentra hacia la derecha.";
                    break;
                case "up":
                    message.text = "La salida de emergencia se encuentra hacia arriba.";
                    break;
                case "down":
                    message.text = "La salida de emergencia se encuentra hacia abajo.";
                    break;
            }
            
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "abuelo")
        {
            signMessage.SetActive(false);
            Debug.Log("exit");
            signWarning.SetActive(false);
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        signMessage.SetActive(true);
        Debug.Log("enter");
        if (collision.gameObject.tag == "abuelo")
        {
            if(signDirection == "left")
            {
                if (horizontal > 0)
                {
                    signWarning.SetActive(true);
                    Debug.Log("wrong");
                }
                else
                {
                    signWarning.SetActive(false);
                    Debug.Log("right");
                }
            }
            else
            {
                if(signDirection == "right")
                {
                    if (horizontal < 0)
                    {
                        signWarning.SetActive(true);
                        Debug.Log("wrong");
                    }
                    else
                    {
                        signWarning.SetActive(false);
                        Debug.Log("right");
                    }
                }
                else
                {
                    if (signDirection == "up")
                    {
                        if (vertical < 0)
                        {
                            signWarning.SetActive(true);
                            Debug.Log("wrong");
                        }
                        else
                        {
                            signWarning.SetActive(false);
                            Debug.Log("right");
                        }
                    }
                    else
                    {
                        if (signDirection == "down")
                        {
                            if (vertical > 0)
                            {
                                signWarning.SetActive(true);
                                Debug.Log("wrong");
                            }
                            else
                            {
                                signWarning.SetActive(false);
                                Debug.Log("right");
                            }
                        }
                    }
                }
            }
        }
    }
}
