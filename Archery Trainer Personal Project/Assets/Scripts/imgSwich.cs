using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class imgSwich : MonoBehaviour
{
    int val = 0;
    public GameObject img1;
    public GameObject img2;
    

    public void changeImg()
    {
        if (val == 0)
        {
            img1.SetActive(true);
        }
        else
        {
            img2.SetActive(false);
        }
    }

}
