using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class SceneChange : MonoBehaviour
{
    public void Loadmain()

    {

        SceneManager.LoadScene("Main");

    }

    public void LoadSelect()

    {

        SceneManager.LoadScene("PlayerSelect");

    }

    public void Backtitle()

    {

        SceneManager.LoadScene("Title");

    }
}
