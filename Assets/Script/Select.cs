using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Select : MonoBehaviour
{
    Button button;
    void Start()
    {
        button = GameObject.Find("Canvas/Button1").GetComponent<Button>();
        //ƒ{ƒ^ƒ“‚ª‘I‘ğ‚³‚ê‚½ó‘Ô‚É‚È‚é
        button.Select();
    }
}
