using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrunkOpen : MonoBehaviour
{
    private float mouseY = -99999;
    private float oldMouseY = -99999;

    public DialogueTrigger next;
    public GameObject enableArrow;

    bool opened = false;

    public void Dragging()
    {
        if (!opened)
        {
            //mouseY = Input.mousePosition.y;
            transform.position = (new Vector3(transform.position.x, Mathf.Clamp(oldMouseY, 320, 451), 0));
            //oldMouseY = Input.mousePosition.y;

            if (transform.position.y > 400)
            {
                StopAllCoroutines();
                StartCoroutine(WaitForABit());
            }
        }
    }

    IEnumerator WaitForABit()
    {
        yield return new WaitForSeconds(0.1f);
        opened = true;

        enableArrow.SetActive(true);
        next.TriggerDialogue();

    }

    public void startDrag ()
    {
        oldMouseY = Input.mousePosition.y;
    }

}
