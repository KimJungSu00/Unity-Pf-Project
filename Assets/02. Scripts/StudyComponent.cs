using System;
using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj;

    public string ObjectName;

    private void Start()
    {
        obj.name = ObjectName;
    }
}
