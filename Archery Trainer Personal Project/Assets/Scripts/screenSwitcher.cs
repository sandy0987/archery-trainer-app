using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class screenSwitcher : MonoBehaviour
{

    public void toScene(string sceneToGo)
    {
        SceneManager.LoadScene(sceneToGo);
    }
}
