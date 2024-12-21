using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UseCollision : MonoBehaviour
{
    public int num = 5;
    public Text Mytxt;
    public void OnCollisionEnter(Collision collision)
    {
        num--;
        Mytxt.text = num.ToString();
    }
}
