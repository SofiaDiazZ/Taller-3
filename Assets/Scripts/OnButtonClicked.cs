using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnButtonClicked : MonoBehaviour
{
   private bool color = false;
   private bool color2 = false;
   private SpriteRenderer colorCubo;
   //int contador;

   void Start()
   {
       colorCubo = GetComponent<SpriteRenderer>();
       color = true;
       color2 = true;
   }

   void Update()
   {
        if(Input.GetMouseButtonDown(0))
       {
           cambiaColor();
       }
   }

   private void cambiaColor()
   {

if(color == true && color2 == false)
{
    colorCubo.material.color = Color.red;
    color = false;
}

else if(color == false && color2 == false)
{
    colorCubo.material.color = Color.yellow;
    color = true;
}

else if(color == false && color2 == true)
{
    colorCubo.material.color = Color.green;
    color2 = true;
}

else if(color == true && color2 == true)
{
    colorCubo.material.color = Color.cyan;
    color2 = true;
}

       /*
       if(contador == 5) contador = 1;
       switch(contador)
       {
           case 1:
           colorCubo.material.color = Color.red;
           contador +=1;
           break;

           case 2:
            colorCubo.material.color = Color.cyan;
            contador +=1;
            break;

            case 3:
            colorCubo.material.color = Color.green;
            contador +=1;
            break;

            case 4:
            colorCubo.material.color = Color.yellow;
            contador +=1;
            break;
       }
       */
   }
}
