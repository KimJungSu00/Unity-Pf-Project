using System;
using UnityEngine;

public class Solar : MonoBehaviour
{

    [SerializeField] private Transform RevolutionTarget;

    [SerializeField] private float BicycleSpeed = 360f;
    [SerializeField] private float RevolutionSpeed = 180f;

    [SerializeField] private float BicycleAxis = 0f;

    private void Start()
    {
        SetBicycleAxis();
    }


    private void Update()
    {
        Bicycle();
        Revolution();
    }

    private void SetBicycleAxis()
    {
        transform.localEulerAngles = new Vector3(BicycleAxis, transform.localEulerAngles.y, transform.localEulerAngles.z);
    }
    
    private void Bicycle()
    {
        transform.Rotate(Vector3.up * BicycleSpeed * Time.deltaTime);
    }
    

    private void Revolution()
    {
        if (!RevolutionTarget) return;
        transform.RotateAround(RevolutionTarget.position, Vector3.up, RevolutionSpeed * Time.deltaTime);
        
    }
    
  
    
    
}
