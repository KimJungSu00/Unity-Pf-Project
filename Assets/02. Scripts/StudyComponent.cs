using System;
using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj;

    public Mesh ObjectMesh;
    public Material ObjectMaterial;

    private void Start()
    {
        // obj = GameObject.Find("Main Camera");
      CreateCube();
CreateCube("Cube2");
    }
    
    private void CreateCube(string name = "Cube")
{
  obj = new GameObject(name);
        obj.AddComponent<MeshFilter>().mesh = ObjectMesh;
        obj.AddComponent<MeshRenderer>().material = ObjectMaterial;
        obj.AddComponent<BoxCollider>();

        Debug.Log(obj.name);
        Debug.Log(obj.tag);

        Debug.Log($"Mesh : {obj.GetComponent<MeshFilter>().mesh}");
        Debug.Log($"Mesh : {obj.GetComponent<MeshRenderer>().material}");
}
}