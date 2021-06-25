using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    public Material[] materials;
    public MeshRenderer mainCameraRenderer;

    public Camera[] cameras;

    public TextMesh cameraZeroFieldOfViewText;
    public TextMesh cameraOneFieldOfViewText;
    public TextMesh cameraTwoFieldOfViewText;
    public TextMesh cameraThreeFieldOfViewText;
    public TextMesh cameraFourFieldOfViewText;
    public TextMesh cameraFiveFieldOfViewText;


    // Start is called before the first frame update
    void Start()
    {
        cameras[0].fieldOfView = 50.0f;

        foreach (var camera in cameras)
        {
            camera.fieldOfView = 50.0f;
        }

    }

    // Update is called once per frame
    void Update()
    {
        //cameraOneFieldOfViewText.text = cameraOneFieldOfView.ToString();
    }


    public void SwitchCamera()
    {
        mainCameraRenderer.material = materials[1];
    }
    
}
