using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_coche2 : MonoBehaviour
{
    bool pulsado = false;
    public GameObject coche;
    public float alpha = 0;
    SpriteRenderer spriteRenderer;


        void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = new Color(255,255,255,1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(coche.transform.position.x, -0.05f, -1);
        spriteRenderer.color = new Color(255,255,255,alpha);

        if (Input.GetKey(KeyCode.Space))
        {
            pulsado = true;
            gameObject.SetActive(true);

            if (alpha < 1)
            {
                alpha = alpha + Time.deltaTime * 0.2f;
            }
        }

        if (!Input.GetKey(KeyCode.Space) && pulsado == true)
        {
            pulsado = false;
            gameObject.SetActive(false);
            alpha = 0;
        }
    }
}
