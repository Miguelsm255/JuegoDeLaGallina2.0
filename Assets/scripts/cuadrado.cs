using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuadrado : MonoBehaviour
{

    public GameObject coche;

    void Start()
    {
        transform.position = new Vector3(30, -9.2f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(coche.transform.position.x +34.3f, -9.2f, 0);
    }
}
