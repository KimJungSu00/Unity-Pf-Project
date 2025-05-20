using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector3 direction;
    [SerializeField] private float moveSpeed = 1f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveInput();
        Move();
    }

    private void MoveInput()
    {
        direction =  new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }
    
    private void Move()
    {
        if (direction == Vector3.zero) return;
        transform.position += (Quaternion.LookRotation(direction) * Vector3.forward) * moveSpeed * Time.deltaTime;

    }
}
