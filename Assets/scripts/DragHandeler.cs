using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;
using System.Collections;
using UnityEngine.EventSystems;

public class DragHandeler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject item;    // i changed itembeigdraged to item.

    Transform startParent;
    Vector3 startPosition;
    public Image imagen;
    public Sprite Inicial, eventual;
    private AudioSource fuente;

  

    public void OnBeginDrag(PointerEventData eventData)
    {
        fuente = GetComponent<AudioSource> ();
        item = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
  
    }


    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
        imagen.overrideSprite = eventual;


    }

    public void OnEndDrag(PointerEventData eventData)
    {
        item = null;

        if (transform.parent == startParent)
        {
            transform.position = startPosition;
        }
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        imagen.overrideSprite = Inicial;
        fuente.Play();



    }

}
