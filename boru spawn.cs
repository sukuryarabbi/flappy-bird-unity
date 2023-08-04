using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boruspawn : MonoBehaviour
{
    [SerializeField]
    private GameObject boru;

    [SerializeField]
    public float boruspawntime;

    [SerializeField]
    public float height;

    private void Start()
    {
        StartCoroutine(boruuspawn());
    }
    private IEnumerator boruuspawn ()
    {
        while(true)
        {

            Instantiate(boru, new Vector3(6, Random.Range(-height, height), 0), Quaternion.identity);

            yield return new WaitForSeconds(boruspawntime);
        }
        
    }

   
}
