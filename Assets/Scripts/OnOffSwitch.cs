using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffSwitch : MonoBehaviour
{
    public GameObject theObject;
    public bool toggle;

    public void Start()
    {
        toggle = theObject.activeInHierarchy;
    }

    public void ToggleOnOff()
    {
        toggle = !toggle;

        theObject.SetActive(toggle);
    }
}
