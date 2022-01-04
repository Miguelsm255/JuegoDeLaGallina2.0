using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class olas : MonoBehaviour
{
    public float ola2;
    public GameObject cuadrado;
    public GameObject pareja;

    void Start()
    {
        transform.position = new Vector3(ola2,-9.2f,-1);
    }


    void Update()
    {
        transform.position = new Vector3(transform.position.x - 1 * Time.deltaTime, transform.position.y, transform.position.z);

        if (cuadrado.transform.position.x - transform.position.x >= 49.5f)
        {
            transform.position = new Vector3(pareja.transform.position.x + 19.95f, transform.position.y, transform.position.z);
        }
    }
}
