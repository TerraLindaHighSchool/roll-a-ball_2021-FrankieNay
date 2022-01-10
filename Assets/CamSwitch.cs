using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CamSwitch : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject Camera2;

   void Update ()
    {
        if (Input.GetButtonDown("1Key"))
        { MainCamera.SetActive(true);
          Camera2.SetActive(false);
        }
        if (Input.GetButtonDown("2Key"))
        {
            MainCamera.SetActive(false);
            Camera2.SetActive(true);
        }
    }
}
