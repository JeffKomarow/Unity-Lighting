using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrussMatChanger : MonoBehaviour
{
    public Material trussMat;


    // Start is called before the first frame update
    void Start()
    {
        MeshRenderer[] materials = GetComponentsInChildren<MeshRenderer>();

        foreach (var item in materials)
        {
            item.material = trussMat;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
