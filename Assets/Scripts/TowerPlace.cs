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
        BuildInGameUI buildInGame = GameManager.UI.ShowInGameUI<BuildInGameUI>("UI/BuildInGameUI");
        buildInGame.SetTarget(transform);
        buildInGame.towerPlace = this;
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

    public void BuildTower(TowerData data)
    {
        GameManager.Resource.Destroy(gameObject);
        GameManager.Resource.Instantiate(data.Towers[0].tower, transform.position, transform.rotation);
    }
}
