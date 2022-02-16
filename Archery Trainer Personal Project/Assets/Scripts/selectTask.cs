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
    public GameObject task5;
    public GameObject task6;
    public GameObject task7;
    public GameObject task8;
    public GameObject task9;


    public GameObject task1Img;
    public GameObject task2Img;
    public GameObject task3Img;
    public GameObject task4Img;
    public GameObject task5Img;
    public GameObject task6Img;
    public GameObject task9Img;

    public void HandleInputData(int val)
    {
        task1.SetActive(true);

        if (val == 0)
        {
            task1.SetActive(true);
            task1Img.SetActive(true);
        }
        else
        {
            task1.SetActive(false);
            task1Img.SetActive(false);
        }
        if (val == 1)
        {
            task2.SetActive(true);
            task2Img.SetActive(true);

        }
        else
        {
            task2.SetActive(false);
            task2Img.SetActive(false);

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
            task5.SetActive(true);
            task5Img.SetActive(true);
        }
        else
        {
            task5.SetActive(false);
            task5Img.SetActive(false);
        }
        if (val == 5)
        {
            task6.SetActive(true);
            task6Img.SetActive(true);
        }
        else
        {
            task6.SetActive(false);
            task6Img.SetActive(false);
        }
        if (val == 6)
        {
            task7.SetActive(true);
        }
        else
        {
            task7.SetActive(false);
        }
        if (val == 7)
        {
            task8.SetActive(true);
        }
        else
        {
            task8.SetActive(false);
        }
        if (val == 8)
        {
            task9.SetActive(true);
            task9Img.SetActive(true);
        }
        else
        {
            task9.SetActive(false);
            task9Img.SetActive(false);
        }
    }
}
