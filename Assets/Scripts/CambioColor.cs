using System.Collections;
using UnityEngine;
using System;

public class CambioColor : MonoBehaviour
{
    public event Action<int> OnButtonClicked;
    public static CambioColor Instance;
    private int color;
    private int contador = 1;
   
    public void Awake()
    {
        if (Instance != null)
    
        Destroy(gameObject);
    

        else
        
        Instance = this;
        
    }

    public void Notify()
    {
        if(OnButtonClicked != null)
        {
            OnButtonClicked(contador);
            contador++;
            if (contador >4)
            {
            contador = 1;
            }
        }
    }
}
