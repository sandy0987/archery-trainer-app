using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class selectTask : MonoBehaviour
{
    public GameObject taskInfo;

    public GameObject StanceInfoText;
    public GameObject GripInfoText;
    public GameObject DrawInfoText;
    public GameObject AnchorInfoText;
    public GameObject ReleaseInfoText;
    public GameObject ExtraThera;

    public GameObject StanceInfoImg;
    public GameObject GripInfoImg;
    public GameObject DrawInfoImg;
    public GameObject AnchorInfoImg;
    public GameObject ReleaseInfoImg;

    public void HandleInputData(int val)
    {
        taskInfo.SetActive(true);

        if (val == 0)
        {
            taskInfo.SetActive(true);
        }
        else
        {
            taskInfo.SetActive(false);
        }
        if (val == 1)
        {
            StanceInfoText.SetActive(true);
            StanceInfoImg.SetActive(true);

        }
        else
        {
            StanceInfoText.SetActive(false);
            StanceInfoImg.SetActive(false);

        }
        if (val == 2)
        {
            GripInfoText.SetActive(true);
            GripInfoImg.SetActive(true);

        }
        else
        {
            GripInfoText.SetActive(false); 
            GripInfoImg.SetActive(false);

        }
        if (val == 3)
        {
            DrawInfoText.SetActive(true);
            DrawInfoImg.SetActive(true);
        }
        else
        {
            DrawInfoText.SetActive(false);
            DrawInfoImg.SetActive(false);
        }
        if (val == 4)
        {
            AnchorInfoText.SetActive(true);
            AnchorInfoImg.SetActive(true);
        }
        else
        {
            AnchorInfoText.SetActive(false);
            AnchorInfoImg.SetActive(false);
        }
        if (val == 5)
        {
            ReleaseInfoText.SetActive(true);
            ReleaseInfoImg.SetActive(true);
        }
        else
        {
            ReleaseInfoText.SetActive(false);
            ReleaseInfoImg.SetActive(false);
        }
        if (val == 6)
        {
            ExtraThera.SetActive(true);
        }
        else
        {
            ExtraThera.SetActive(false);
        }
    }
}
