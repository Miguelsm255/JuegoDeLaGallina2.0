using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_coche : MonoBehaviour
{
    public int velocidad;
    public int contador;   public float timer;
    public bool pulsado = false;
    public float linearDrag;
    public int pulsosAEsperar;
    public bool correr = true;

    void Start()
    {
        
    }


    void Update()
    {

        if (correr == true && Input.GetKey(KeyCode.Space))
        {
            pulsado = true;
            gameObject.GetComponent<Animator>().SetBool("pulsado", true);

            timer = timer + 1 * Time.deltaTime;
            contador = (int)timer;
        }

        if (!Input.GetKey(KeyCode.Space) && pulsado == true)
        {
            correr = false;
            pulsado = false;
            gameObject.GetComponent<Animator>().SetBool("pulsado", false);
            //gameObject.GetComponent<Animator>().SetBool("correr", true);
            LanzarCoche();
        } 
    }

    void LanzarCoche()
    {


        // 1 segundo
        if (timer < 1.1f)
        {
            Debug.Log("Demasiado corto");
            gameObject.GetComponent<Animator>().SetBool("muyCorto", true);
        }

        else if (timer >= 1.1 && timer < 1.3)
        {

        }

        else if (timer >= 1.3 && timer < 1.5)
        {

        }

        else if (timer >= 1.5 && timer < 1.7)
        {

        }

        else if (timer >= 1.7 && timer < 1.9)
        {

        }

        // 2 segundos

        else if (timer == 2)
        {

        }

        else if (timer >= 2.1 && timer < 2.3)
        {

        }

        else if (timer >= 2.3 && timer < 2.5)
        {

        }

        else if (timer >= 2.5 && timer < 2.7)
        {

        }

        else if (timer >= 2.7 && timer < 2.9)
        {

        }

        // 3 segundos

        else if (timer == 3)
        {

        }

        else if (timer >= 3.1 && timer < 3.3)
        {

        }

        else if (timer >= 3.3 && timer < 3.5)
        {

        }

        else if (timer >= 3.5 && timer < 3.7)
        {

        }

        else if (timer >= 3.7 && timer < 3.9)
        {

        }

        // 4 segundos

        else if (timer == 4)
        {

        }

        else if (timer >= 4.1 && timer < 4.3)
        {

        }

        else if (timer >= 4.3 && timer < 4.5)
        {

        }

        else if (timer >= 4.5 && timer < 4.7)
        {

        }

        else if (timer >= 4.7 && timer < 4.9)
        {

        }

        // 5 segundos

        else if (timer == 5)
        {

        }

        else if (timer >= 5.1 && timer < 5.3)
        {

        }

        else if (timer >= 5.3 && timer < 5.5)
        {

        }

        else if (timer >= 5.5 && timer < 5.7)
        {

        }

        else if (timer >= 5.7 && timer < 5.9)
        {

        }

        // 6 segundos

        else if (timer == 6)
        {

        }

        else if (timer >= 6.1 && timer < 6.3)
        {

        }

        else if (timer >= 6.3 && timer < 6.5)
        {

        }

        else if (timer >= 6.5 && timer < 6.7)
        {

        }

        else if (timer >= 6.7 && timer < 6.9)
        {

        }

        // 7 segundos

        else if (timer == 7)
        {

        }

        else if (timer >= 7.1 && timer < 7.3)
        {

        }

        else if (timer >= 7.3 && timer < 7.5)
        {

        }

        else if (timer >= 7.5 && timer < 7.7)
        {

        }

        else if (timer >= 7.7 && timer < 7.9)
        {

        }

        // 8 segundos

        else if (timer == 8)
        {

        }

        else if (timer >= 8.1 && timer < 8.3)
        {

        }

        else if (timer >= 8.3 && timer < 8.5)
        {

        }

        else if (timer >= 8.5 && timer < 8.7)
        {

        }

        else if (timer >= 8.7 && timer < 8.9)
        {

        }

        // 9 segundos

        else if (timer == 9)
        {

        }

        else if (timer >= 9.1 && timer < 9.3)
        {

        }

        else if (timer >= 9.3 && timer < 9.5)
        {

        }

        else if (timer >= 9.5 && timer < 9.7)
        {

        }

        else if (timer >= 9.7 && timer < 9.9)
        {

        }
        
        // 10 segundo

        else if (timer >= 10.1 && timer < 10.3)
        {

        }

        else if (timer >= 10.3 && timer < 10.5)
        {

        }

        else if (timer >= 10.5 && timer < 10.7)
        {

        }

        else if (timer >= 10.7 && timer < 10.9)
        {

        }

        // 11 segundo
        
        else if (timer >= 11.1 && timer < 11.3)
        {

        }

        else if (timer >= 11.3 && timer < 11.5)
        {

        }

        else if (timer >= 11.5 && timer < 11.7)
        {

        }

        else if (timer >= 11.7 && timer < 11.9)
        {

        }

        // 12 segundo
        
        else if (timer >= 12.1 && timer < 12.3)
        {

        }

        else if (timer >= 12.3 && timer < 12.5)
        {

        }

        else if (timer >= 12.5 && timer < 12.7)
        {

        }

        else if (timer >= 12.7 && timer < 12.9)
        {

        }

        // 13 segundo
        
        else if (timer >= 13.1 && timer < 13.3)
        {

        }

        else if (timer >= 13.3 && timer < 13.5)
        {

        }

        else if (timer >= 13.5 && timer < 13.7)
        {

        }

        else if (timer >= 13.7 && timer < 13.9)
        {

        }

        // 14 segundo
        
        else if (timer >= 14.1 && timer < 14.3)
        {

        }

        else if (timer >= 14.3 && timer < 14.5)
        {

        }

        else if (timer >= 14.5 && timer < 14.7)
        {

        }

        else if (timer >= 14.7 && timer < 14.9)
        {

        }

        // 15 segundo
        
        else if (timer >= 15.1 && timer < 15.3)
        {

        }

        else if (timer >= 15.3 && timer < 15.5)
        {

        }

        else if (timer >= 15.5 && timer < 15.7)
        {

        }

        else if (timer >= 15.7 && timer < 15.9)
        {

        }

        // 16 segundo
        
        else if (timer >= 16.1 && timer < 16.3)
        {

        }

        else if (timer >= 16.3 && timer < 16.5)
        {

        }

        else if (timer >= 16.5 && timer < 16.7)
        {

        }

        else if (timer >= 16.7 && timer < 16.9)
        {

        }

        // 17 segundo
        
        else if (timer >= 17.1 && timer < 17.3)
        {

        }

        else if (timer >= 17.3 && timer < 17.5)
        {

        }

        else if (timer >= 17.5 && timer < 17.7)
        {

        }

        else if (timer >= 17.7 && timer < 17.9)
        {

        }

        // 18 segundo
        
        else if (timer >= 18.1 && timer < 18.3)
        {

        }

        else if (timer >= 18.3 && timer < 18.5)
        {

        }

        else if (timer >= 18.5 && timer < 18.7)
        {

        }

        else if (timer >= 18.7 && timer < 18.9)
        {

        }

        // 19 segundo
        
        else if (timer >= 19.1 && timer < 19.3)
        {

        }

        else if (timer >= 19.3 && timer < 19.5)
        {

        }

        else if (timer >= 19.5 && timer < 19.7)
        {

        }

        else if (timer >= 19.7 && timer < 19.9)
        {

        }



        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(velocidad , 0));     
    }

    void Frenado(float lineardrag)
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(velocidad , 0));

        //Ir a maxima velocidad durante la mitad del tiempo
        gameObject.GetComponent<Rigidbody2D>().drag = 0;
        EsperarSegundos(contador/2);

        //el siguiente cuarto subir el linear drag para frenar
        gameObject.GetComponent<Rigidbody2D>().drag = lineardrag;
        EsperarSegundos(contador/4);

        //en el ultimo cuarto bajar el linear drag para que se pare del todo
        gameObject.GetComponent<Rigidbody2D>().drag = lineardrag/2;
    }


    IEnumerator EsperarSegundos(float segundos)
    {
        yield return new WaitForSeconds(segundos);
    }
}
