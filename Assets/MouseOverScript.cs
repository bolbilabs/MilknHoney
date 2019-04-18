using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Events;

public class MouseOverScript : EventTrigger
{



    void Update()
    {

        //GetComponent<Button>().OnPointerEnter

        //if (this.GetComponent<Button>().OnPointerEnter.IsInvoking())
        //{
        //    transform.parent.GetChild(1).GetChild(0).gameObject.SetActive(true);
        //}
        //else
        //{
        //    transform.parent.GetChild(1).GetChild(0).gameObject.SetActive(false);
        //}
    }


    public void ShowText()
    {
        transform.parent.GetChild(1).GetChild(0).gameObject.SetActive(true);
    }

    public void UnshowText()
    {
        transform.parent.GetChild(1).GetChild(0).gameObject.SetActive(false);
    }
}
