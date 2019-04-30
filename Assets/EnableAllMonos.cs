using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableAllMonos : MonoBehaviour
{
    public MonoBehaviour[] monoBehaviours;

    public void EnableAllMonobehaviors()
    {
        foreach (MonoBehaviour mono in monoBehaviours)
        {
            mono.enabled = true;
        }
    }
}
