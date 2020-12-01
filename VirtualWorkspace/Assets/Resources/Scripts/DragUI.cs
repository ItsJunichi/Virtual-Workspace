using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class DragUI : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IPointerDownHandler
{

    [SerializeField] private RectTransform dragRectTransform;
    [SerializeField] private Canvas canvas;
    [SerializeField] private Image backgroundImg;
    private Color backgroundColor;

    private void Awake()
    {
        backgroundColor = backgroundImg.color;

        if ( dragRectTransform == null)
        {
            dragRectTransform = transform.parent.GetComponent<RectTransform>();
        }
   
     }

    public void OnBeginDrag(PointerEventData eventData)
    {
        backgroundColor.a = .4f;
        backgroundImg.color = backgroundColor;
    }

    public void OnDrag(PointerEventData eventData)
    {
        dragRectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        backgroundColor.a = 1f;
        backgroundImg.color = backgroundColor;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        dragRectTransform.SetAsLastSibling();
    }
}
