using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fondo : MonoBehaviour
{

    public GameObject coche;

    void Start()
    {
        transform.position = new Vector3(5.7f, -2.6f, 3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(coche.transform.position.x +10, transform.position.y, transform.position.z);
    }
}
