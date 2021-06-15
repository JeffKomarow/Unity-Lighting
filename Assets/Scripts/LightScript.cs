using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    public Transform actor;

    Transform lightATransform;

    Light lightAColor;

    public Color lightColor;

    // Start is called before the first frame update
    void Start()
    {
        // Make a game object
        GameObject lightGameObject = new GameObject("Light " + actor.gameObject.name);
        lightATransform = lightGameObject.transform;

        // Add the light component
        Light lightA = lightGameObject.AddComponent<Light>();
        lightAColor = lightA;

        // Change the light from a point light to a spot light
        lightA.type = LightType.Spot;

        // get the position of actor
        Vector3 lightAPosition = actor.position;

        // choose the offset of the light
        lightAPosition += new Vector3(3, 4, 0);

        //move the light in code
        lightA.transform.position = lightAPosition;

        //point the light at the actor
        // lightA.transform.LookAt(actorA);

        //change the color using colors
        lightA.color = Color.red;

        // change the color using RGB values
        lightA.color = new Color32(0, 255, 255, 255);

        lightA.color = lightColor;

        //change the intensity
        lightA.intensity = 4;
    }

    // Update is called once per frame
    void Update()
    {
        lightATransform.LookAt(actor);

        lightAColor.color = lightColor;
    }
}
