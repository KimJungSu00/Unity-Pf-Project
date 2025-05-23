using UnityEngine;

public class StudyBullet : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position += transform.forward * (moveSpeed * Time.deltaTime);
    }
}
