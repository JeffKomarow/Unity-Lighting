using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraManager : MonoBehaviour
{

    public Material[] materials;
    public MeshRenderer mainCameraRenderer;

    public Camera[] cameras;

    public Camera selectedCamera;
    public Image selectedButtonImage;
    public GameObject noCameraSelected;

    public TextMesh cameraZeroFieldOfViewText;
    public TextMesh cameraOneFieldOfViewText;
    public TextMesh cameraTwoFieldOfViewText;
    public TextMesh cameraThreeFieldOfViewText;
    public TextMesh cameraFourFieldOfViewText;
    public TextMesh cameraFiveFieldOfViewText;

    public Image[] buttonImages;


    public Text cameraCount;


    // Start is called before the first frame update
    void Start()
    {
        cameras[0].fieldOfView = 50.0f;

        foreach (var camera in cameras)
        {
            camera.fieldOfView = 50.0f;
        }

        CameraCount();

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

    public void CameraCount()
    {
        int count = Camera.allCamerasCount -1;
        cameraCount.text = "There are " + count + " cameras";
    }

    public void ChangeActiveCamera(int cameraID)
    {
        selectedCamera = cameras[cameraID];
        noCameraSelected.SetActive(false);

        if ( selectedButtonImage != null)
        {
            selectedButtonImage.color = Color.grey;
        }

        selectedButtonImage = buttonImages[cameraID];

        buttonImages[cameraID].color = Color.red;

    }

    public void ChangeFocalLength(int mm)
    {
        if (selectedCamera != null)
        {
            selectedCamera.focalLength = mm;
        }
        else
        {
            noCameraSelected.SetActive(true);
        }
    }

    //public void PanTiltCamera(int );
}
