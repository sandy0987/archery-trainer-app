using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class selectTask : MonoBehaviour
{
    public TextMeshProUGUI taskInfo;


    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            taskInfo.text = "This is when you are ready with your theraband. " +
                "1) Stand straight and keep shoulder level distance in your feet" +
                "2) You should use your weak arm(bow arm) to hold the bow and strong arm to pull it. If you are a righty, aim the target with your left arm." +
                "3) Slightly move your feet towards your target(the direction where you will be looking)" +
                "4) Now, turn your head towards your target, remember to keep your back and neck in a line" +
                "5) Lift your weak arm in a straight line" +
                "6) Try to keep your shoulders aligned and straight";
        }
        if (val == 1)
        {
            taskInfo.text = "Continue when you are ready with the stance. " +
                 "1) Fold your band in half and hold the two ends in your bow hand. " +
                 "2) Hold the 2 ends upwards and place the band between your palm. Gently hold it." +
                 "3) ";
        }
        if (val == 2)
        {
            taskInfo.text = "Learn to Draw your theraband!";
        }
        if (val == 3)
        {
            taskInfo.text = "Learn to Anchor!";
        }
        if (val == 4)
        {
            taskInfo.text = "Learn to Release the band!";
        }


    }
}
