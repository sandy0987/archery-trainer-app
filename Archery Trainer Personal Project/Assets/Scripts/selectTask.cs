using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class selectTask : MonoBehaviour
{
    public TextMeshProUGUI taskInfo;

    public GameObject StanceInfoText;
    public GameObject GripInfoText;
    public GameObject DrawInfoText;
    public GameObject AnchorInfoText;
    public GameObject ReleaseInfoText;

    public void HandleInputData(int val)
    {
        
        if (val == 0)
        {
            StanceInfoText.SetActive(true);
        }
        else
        {
            StanceInfoText.SetActive(false);
        }
        if (val == 1)
        {
            GripInfoText.SetActive(true);
        }
        else
        {
            GripInfoText.SetActive(false);
        }
        if (val == 2)
        {
            DrawInfoText.SetActive(true);
        }
        else
        {
            DrawInfoText.SetActive(false);
        }
        if (val == 3)
        {
            AnchorInfoText.SetActive(true);
        }
        else
        {
            AnchorInfoText.SetActive(false);
        }
        if (val == 4)
        {
            ReleaseInfoText.SetActive(true);
        }
        else
        {
            ReleaseInfoText.SetActive(false);
        }


    }
}
