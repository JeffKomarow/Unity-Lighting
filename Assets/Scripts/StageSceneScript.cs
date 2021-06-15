using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSceneScript : MonoBehaviour
{
    public List<Light> lights = new List<Light>();

    public GameObject[] objectToAddLights;

    public GameObject lightPrefab;

    public GameObject characterActor;



    // Start is called before the first frame update
    void Start()
    {

        foreach (var item in objectToAddLights)
        {
            GameObject newlightObject = Instantiate(lightPrefab, item.transform);
            newlightObject.transform.localPosition = new Vector3(-6, 1, 0);

            lights.Add(newlightObject.GetComponentInChildren<Light>());

            GameObject newlightObject2 = Instantiate(lightPrefab, item.transform);
            newlightObject2.transform.localPosition = new Vector3(-8, 1, 0);

            lights.Add(newlightObject2.GetComponentInChildren<Light>());

            GameObject newlightObject3 = Instantiate(lightPrefab, item.transform);
            newlightObject3.transform.localPosition = new Vector3(-10, 1, 0);

            lights.Add(newlightObject3.GetComponentInChildren<Light>());

        }

        foreach (var item in lights)
        {
            item.transform.LookAt(characterActor.transform);
            item.intensity = 4;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
