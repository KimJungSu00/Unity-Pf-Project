using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Transform TurretHead;

    [SerializeField] private GameObject Bullet;
    [SerializeField] private Transform firePos;
    [SerializeField] private float bulletDelay = 0.1f;

    private float currentTime = 1;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FindTarget();
    }

    // Update is called once per frame
    void Update()
    {
        LookAt();
        Shot();
    }

    private void FindTarget()
    {
        if (target != null) return;
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    
    private void LookAt()
    {
        if (target == null) return;
        if (TurretHead == null) return;
        TurretHead.transform.LookAt(target);
    }

    private void Shot()
    {
        currentTime += Time.deltaTime;
        if (Input.GetKey(KeyCode.Space))
        {
            if (currentTime >= bulletDelay)
            {
                var bullet =  Instantiate(Bullet, firePos.position, firePos.rotation);
                currentTime = 0;
            }
        }
    }
}
