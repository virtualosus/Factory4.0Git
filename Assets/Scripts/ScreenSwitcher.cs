using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenSwitcher : MonoBehaviour
{
    public GameObject switchToAR, switchTo3D, ARCanvasDisplay, factory;

    // Start is called before the first frame update
    void Start()
    {
        ARMode();
    }

    public void ARMode()
    {
        switchToAR.SetActive(false);
        switchTo3D.SetActive(true);
        ARCanvasDisplay.SetActive(true);
        factory.SetActive(false);
    }

    public void ThreeDMode()
    {
        switchToAR.SetActive(true);
        switchTo3D.SetActive(false);
        ARCanvasDisplay.SetActive(false);
        factory.SetActive(true);
    }
}
