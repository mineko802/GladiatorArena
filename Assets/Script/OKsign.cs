using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OKsign : MonoBehaviour
{
    public GameObject OKsignA;
    public GameObject OKsignB;
    public GameObject Fight;
    // Start is called before the first frame update
    void Start()
    {
        OKsignA.SetActive(false);
        OKsignB.SetActive(false);
        Fight.SetActive(false);
    }

    private string Battle()
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("ActiveA");
            OKsignA.SetActive(true);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("ActiveB");
            OKsignB.SetActive(true);
        }

        if (OKsignA.activeSelf)
        {
        if (OKsignB.activeSelf)
        {
            Fight.SetActive(true);
        }
        }
    }
}
