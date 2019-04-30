using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseVisible : MonoBehaviour
{
    public bool isVisible = true;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = isVisible;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
