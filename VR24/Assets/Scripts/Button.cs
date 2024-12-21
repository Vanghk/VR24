using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public GameObject test;
    public void OnButton()
    {
        test.SetActive(!(test.activeSelf));
    }
}