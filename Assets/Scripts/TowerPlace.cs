using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class TowerPlace : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler, IDragHandler
{

    [SerializeField] Color normal;
    [SerializeField] Color OnMouse;

    private Renderer render;

    private void Awake()
    {
        render = GetComponent<Renderer>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        Debug.Log("너 좌클된거야");

       else if (eventData.button == PointerEventData.InputButton.Right)
        Debug.Log("너 우클된거야");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        render.material.color = OnMouse;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        render.material.color = normal;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position += new Vector3(eventData.delta.x,0, eventData.delta.y);
    }
}
