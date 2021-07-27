using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void GoScan()
    {
        SceneManager.LoadScene(1);
    }
    
    public void GoBack()
    {
        SceneManager.LoadScene(0);
    }
}
