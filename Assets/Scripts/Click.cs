using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
   
   private void Update()
    {
        
        if(Input.GetMouseButtonDown(1))
       {
           CambioColor.Instance.Notify();
       }
       
    }
}
