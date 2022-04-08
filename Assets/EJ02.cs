//2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.
//Comunicar si la suma de los mismos supera o no el monto de dinero disponible.
//Luego indicar cuánto dinero sobra o falta.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ02 : MonoBehaviour
{
    public float PrecioProducto1, PrecioProducto2, PrecioProducto3, MontoDinero;
    float sumaPrecios;
    // Start is called before the first frame update
    void Start()
    {
        sumaPrecios = PrecioProducto1 + PrecioProducto2 + PrecioProducto3;
        if(sumaPrecios > MontoDinero)
        {

            Debug.Log("La suma de los productos supera al monto de dinero disponible. Le faltan $" + (sumaPrecios - MontoDinero));
        }
        else
        {
            Debug.Log("La suma de los productos no supera el monto de dinero disponible. Le sobran $" + (MontoDinero - sumaPrecios));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
