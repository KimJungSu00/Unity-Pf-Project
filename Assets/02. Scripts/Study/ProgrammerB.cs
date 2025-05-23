using System;
using DevA;
using UnityEngine;

public class ProgrammerB : MonoBehaviour
{
    public ProgrammerA pA;

    public void Start()
    {
        pA.number1 = 10;
        pA.number2 = 20;
        pA.number3 = 30;
        pA.number4 = 40;
        pA.number5 = 50;
        Debug.Log(pA.number1);
        Debug.Log(pA.number2);
        Debug.Log(pA.number3);
        Debug.Log(pA.number4);
        Debug.Log(pA.number5);
    }
}
