using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrasesMotivacionales : MonoBehaviour
{
    bool parado = false;
    float contadorDeTiempo = 0f;
    public Text texto;
    int incr = 0;
    List<string> Frases = new List<string> { "El lado positivo del CoronaVirus es que no tenemos clase", "El lado negativo es que estamos en la ESCAV", "Asi que tenemos tarea x2", "Y encima tenemos que usar el Zoom", "Todo me male sal" };
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Frases.Count; i++)
        {
            Debug.Log(Frases[i]);
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (parado == false)
        {
            contadorDeTiempo += Time.deltaTime;

            //si el tiempo transcurrido (contadorDeTiempo) es mayor o igual a 10
            if (contadorDeTiempo >= 10f)
            {
                //Cambiamos el texto del objeto text
                texto.text = Frases[incr];
                //reiniciamos el contador de tiempo a 0
                contadorDeTiempo = 0f;
                //sumamos el incremental para coger la siguente frase
                incr++;
                //si el incremental se pasa de la lista, significa que tenemos que volver a recorrer la lista
                //entonces reinicializamos el incremental a 0
                if (incr >= Frases.Count)
                {
                    incr = 0;
                }
            }
        }
     
    }

    public void cambiar()
    {
        incr = UnityEngine.Random.Range(0, Frases.Count);
        texto.text = Frases[incr];
    }

    public void parar()
    {
        if (parado == false)
        {
            parado = true;
        }

        else
        {
            parado = false;
        }
    }
}
