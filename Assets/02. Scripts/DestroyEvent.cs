using System;
using UnityEngine;

public class DestroyEvent : MonoBehaviour
{
    public float DestroyTime = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject, DestroyTime);
      
    }

    private void OnDestroy()
    {
        Debug.Log($"{Time.time} - {this.gameObject.name} is destroyed");
    }
}
