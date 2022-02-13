using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class selectTask : MonoBehaviour
{
    public GameObject task1;

    public GameObject task2;
    public GameObject task3;
    public GameObject task4;
    public GameObject task6;
    public GameObject task7;
    public GameObject task8;

    public GameObject task2img;
    public GameObject task3Img;
    public GameObject task4Img;
    public GameObject task6Img;
    public GameObject task7Img;

    public void HandleInputData(int val)
    {
        task1.SetActive(true);

        if (val == 0)
        {
            task1.SetActive(true);
        }
        else
        {
            task1.SetActive(false);
        }
        if (val == 1)
        {
            task2.SetActive(true);
            task2img.SetActive(true);

        }
        else
        {
            task2.SetActive(false);
            task2img.SetActive(false);

        }
        if (val == 2)
        {
            task3.SetActive(true);
            task3Img.SetActive(true);

        }
        else
        {
            task3.SetActive(false); 
            task3Img.SetActive(false);

        }
        if (val == 3)
        {
            task4.SetActive(true);
            task4Img.SetActive(true);
        }
        else
        {
            task4.SetActive(false);
            task4Img.SetActive(false);
        }
        if (val == 4)
        {
            task6.SetActive(true);
            task6Img.SetActive(true);
        }
        else
        {
            task6.SetActive(false);
            task6Img.SetActive(false);
        }
        if (val == 5)
        {
            task7.SetActive(true);
            task7Img.SetActive(true);
        }
        else
        {
            task7.SetActive(false);
            task7Img.SetActive(false);
        }
        if (val == 6)
        {
            task8.SetActive(true);
        }
        else
        {
            task8.SetActive(false);
        }
    }
}
