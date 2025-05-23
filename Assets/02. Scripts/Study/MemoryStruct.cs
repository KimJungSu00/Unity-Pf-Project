using System;
using UnityEngine;

public class MemoryStruct : MonoBehaviour
{
    private void Start()
    {
        StudyClass c1 = new StudyClass(1);
        StudyStruct s1 = new StudyStruct(2);
        
        Debug.Log($"Class {c1} : {c1.ID} / Struct {s1} : {s1.ID}");
    }
}

public class StudyClass
{
    public int ID;

    public StudyClass(int id)
    {
        ID = id;
    }
}

public struct StudyStruct
{
    public int ID;

    public StudyStruct(int id)
    {
        ID = id;
    }
}