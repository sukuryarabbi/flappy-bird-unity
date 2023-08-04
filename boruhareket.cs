using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class borushareket : MonoBehaviour
{
    [SerializeField]
    public float speed;

    void Start()
    {
        Destroy(gameObject, 10f);
    }

    
    void Update()
    {
        transform.position += Vector3.left * speed;
        
    }
    
}
