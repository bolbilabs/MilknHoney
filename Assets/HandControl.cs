using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandControl : MonoBehaviour
{
    public Animator handAnim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false;

        transform.position = Input.mousePosition;

        if (Input.GetMouseButton(0))
        {
            handAnim.SetBool("Grab", true);
        }
        else
        {
            handAnim.SetBool("Grab", false);
        }
    }
}
