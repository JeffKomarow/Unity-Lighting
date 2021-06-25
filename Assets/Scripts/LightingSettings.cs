using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightingSettings : MonoBehaviour
{
    public Light[] groupOne;
    public Light[] groupTwo;

    Light[] activeGroup;

    public Color[] notRandomColors;

    public Button notRandomColorsButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeActiveLightGroup(int LightGroupID)
    {
        if (LightGroupID == 0)
        {
            activeGroup = groupOne;
        }
        else if (LightGroupID == 1)
        {
            activeGroup = groupTwo;
        }
    }

    public void RandomizeColorTotally()
    {
        Color randomizeColor = new Color32((byte)Random.Range(0, 256), (byte)Random.Range(0, 256), (byte)Random.Range(0, 256), 255);

        foreach (var item in activeGroup)
        {
            item.color = randomizeColor;
        }
    }

    public void RandomizeColorFromList()
    {
        Color randomizeColor = notRandomColors[Random.Range(0, notRandomColors.Length)];

        foreach (var item in activeGroup)
        {
            item.color = randomizeColor;
        }
        notRandomColorsButton.image.color = randomizeColor;
    }
}
