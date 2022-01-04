using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_camara : MonoBehaviour
{

    public GameObject coche;

    void Update()
    {

        transform.position = new Vector3 ( coche.transform.position.x + 4.3f , 0 , -10);
    }
}
