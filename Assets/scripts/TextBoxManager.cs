using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using UnityEngine.SceneManagement;

public class TextBoxManager : MonoBehaviour,IPointerClickHandler {
    public Text theText;
    public string[] textLines;
    private int currentLine,endAtLine;
    private AudioSource sonido;
    public void OnPointerClick(PointerEventData eventData)
    {
        
        if (currentLine <= endAtLine)
        {
            theText.text = textLines[currentLine];
        }
        sonido.Play ();
     
        currentLine++;
    }

    void Start()
    {
        sonido = GetComponent<AudioSource>();
        endAtLine = textLines.Length - 1;
        theText.text = textLines[currentLine];
        currentLine++;
       
       
    }
}
