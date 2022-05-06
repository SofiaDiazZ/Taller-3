using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observador : MonoBehaviour
{
    private SpriteRenderer colorCubo;
    void Start()
    {
        colorCubo= gameObject.GetComponent<SpriteRenderer>();
        CambioColor.Instance.OnButtonClicked+= color;
    }

    private void color(int contador)
    {
        cambiaColor(contador);
    }

    private void cambiaColor(int contador)
   {

       switch(contador)
       {
           case 1:
           colorCubo.material.color = Color.red;
           break;

           case 2:
            colorCubo.material.color = Color.cyan;
            
            break;

            case 3:
            colorCubo.material.color = Color.green;
            
            break;

            case 4:
            colorCubo.material.color = Color.yellow;
            
            break;
       }
       
   }
}
