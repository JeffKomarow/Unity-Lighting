using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject cameraSettingsPanel;
    public GameObject projectSettingsPanel;
    public GameObject lightingSettingsPanel;




    // Start is called before the first frame update
    void Start()
    {
        cameraSettingsPanel.gameObject.SetActive(false);
        projectSettingsPanel.gameObject.SetActive(false);
        lightingSettingsPanel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseSettingsPanels()
    {
        cameraSettingsPanel.gameObject.SetActive(false);
        projectSettingsPanel.gameObject.SetActive(false);
        lightingSettingsPanel.gameObject.SetActive(false);
    }
}
