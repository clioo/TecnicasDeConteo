using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Resultados : MonoBehaviour {
    public AudioClip sonidoCorrecto, sonidoIncorrecto;
    public bool importaOrden;
    public string siguienteNivel;
    public GameObject panel;
    public Text texto;
    public string[] respuestas;
    private bool siguiente = false;
    private AudioSource sonido;
    public void Start(){
        sonido = GetComponent < AudioSource> ();
    }
    public void Comprobar()
    {
        if (siguiente) {
            SceneManager.LoadScene (siguienteNivel);
        }
        bool correcto = false;
        if (importaOrden) {
            int i = 0;
            foreach (string item in respuestas) {
             
                if (panel.transform.GetChild(i).transform.GetChild(0).name == item)
                {
                    correcto = true;
                } else {
                    correcto = false;
                    break;
                }
                i++;
            }
        } else {
            for (int i = 0; i < respuestas.Length; i++)
            {

                for (int x = 0; x < panel.transform.childCount; x++)
                {
                    if (panel.transform.GetChild(x).transform.FindChild(respuestas[i]))
                    {
                        correcto = true;
                        break;
                    }
                    correcto = false;
                }
                if (correcto == false)
                {
                    break;
                }


            }
        }

       


        if (correcto)
        {
            sonido.clip = sonidoCorrecto;
            sonido.Play ();
            texto.text = "¡Tu respuesta es correcta ! presiona para continuar";
            siguiente = true;
        }
        else
        {
            sonido.clip = sonidoIncorrecto;
            sonido.Play();
            texto.text = "¡¡¡Intentemos una vez mas!!!";
        }

        
     
    }
}
