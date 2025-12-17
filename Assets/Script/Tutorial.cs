using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    // Update is called once per frame
    public void OnClick()
    {
            SceneManager.LoadScene("Tutorial Scenes");
    }
}
