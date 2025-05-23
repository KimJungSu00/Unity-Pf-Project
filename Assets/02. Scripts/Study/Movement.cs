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
        Rotation();
        Move();
    }

    private void MoveInput()
    {
        direction =  new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        direction = direction.normalized;
    }
    
    private void Move()
    {
        if (direction == Vector3.zero) return;
      
        transform.position += (Quaternion.LookRotation(direction) * Vector3.forward) * moveSpeed * Time.deltaTime;

    }

    private void Rotation()
    {
        transform.LookAt(transform.position + direction,Vector3.up);
    }
}
