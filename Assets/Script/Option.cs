using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Option : MonoBehaviour
{
    // Update is called once per frame
    public void OnClick()
    {
            SceneManager.LoadScene("Option Scenes");
    }
}
