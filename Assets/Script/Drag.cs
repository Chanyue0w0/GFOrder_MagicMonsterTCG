using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour ,IBeginDragHandler,IDragHandler,IEndDragHandler
{
    public Transform parentToReturnTo;
    //public Vector3 originPosition;

    public void OnBeginDrag(PointerEventData eventData)
    {

        parentToReturnTo = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);//remove from parent
        //originPosition = this.transform.position;
        //GetComponent<CanvasGroup>().blocksRaycasts = false;
        //Debug.Log("BeginDrag");
    }
    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;
        //Debug.Log("Drag");
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.SetParent(parentToReturnTo);
        //this.transform.position = originPosition;
        //GetComponent<CanvasGroup>().blocksRaycasts = true;
        Debug.Log("EndDrag");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
