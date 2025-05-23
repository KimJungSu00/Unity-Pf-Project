using UnityEngine;

public class StudyGameObject : MonoBehaviour
{

    public GameObject prefabs;

    public GameObject Ground;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        Spawn();
        RemoveGround();
        
        
    }

    private void Spawn()
    {
       var obj = Instantiate(prefabs);
       CountChile(obj.transform);
    }

    private void RemoveGround()
    {
        GameObject.Destroy(Ground,3f);
    }

    private void CountChile(Transform obj, Transform parent = null)
    {
        for (var i = 0; i < obj.childCount; i++)
        {
            CountChile(obj.GetChild(i), obj);
            Debug.Log($"{obj.GetChild(i).name}" + (parent != null ? $"Parent : {parent}" : string.Empty));
        }
    }

 
}
