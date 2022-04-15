using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba5 : MonoBehaviour
{
    public string producto1;
    public string producto2;
    public string producto3;
    public int precio1;
    public int precio2;
    public int precio3;
    public int cantidadproducto1;
    public int cantidadproducto2;
    public int cantidadproducto3;


    // Start is called before the first frame update
    void Start()
    {
        int preciototal = precio1 + precio2 + precio3;
        int descuentoproducto1 = precio1 / 5;
        int descuentoproducto2 = precio2 / 5;
        int descuentoproducto3 = precio3 / 5;
        int preciocondescuento1 = preciototal - descuentoproducto1;
        int preciocondescuento2 = preciototal - descuentoproducto2;
        int preciocondescuento3 = preciototal - descuentoproducto3;
        int descuentoproducto12 = descuentoproducto1 + descuentoproducto2;
        int descuentoproducto13 = descuentoproducto1 + descuentoproducto3;
        int descuentoproducto23 = descuentoproducto2 + descuentoproducto3;
        int preciocondescuento12 = preciototal - descuentoproducto12;
        int preciocondescuento13 = preciototal - descuentoproducto13;
        int preciocondescuento23 = preciototal - descuentoproducto23;
        int descuentoproducto123 = descuentoproducto1 + descuentoproducto2 + descuentoproducto3;
        int preciocondescuento123 = preciototal - descuentoproducto123;

        if (precio1 <= 0)
        {
            Debug.Log("El precio debe ser mayor a cero");
        }
        if (precio2 <= 0)
        {
            Debug.Log("El precio debe ser mayor a cero");
        }
        if (precio3 <= 0)
        {
            Debug.Log("El precio debe ser mayor a cero");
        }
        if (cantidadproducto1 <= 0)
        {
            Debug.Log("La cantidad de producto debe ser mayor a cero");
        }
        if (cantidadproducto2 <= 0)
        {
            Debug.Log("La cantidad de producto debe ser mayor a cero");
        }
        if (cantidadproducto3 <= 0)
        {
            Debug.Log("La cantidad de producto debe ser mayor a cero");
        }
        if(cantidadproducto1 >= 3 && cantidadproducto2 >= 3 && cantidadproducto3 >= 3)
        {
            Debug.Log("El total de los tres productos es de " + preciototal);
        }
        if(cantidadproducto1 <= 3)
        {
            Debug.Log("Su total es " + preciototal + " el descuento es de " + descuentoproducto1 + " si aplicamos el descuento, su total es de " + preciocondescuento1);
        }
        if (cantidadproducto2 <= 3)
        {
            Debug.Log("Su total es " + preciototal + " el descuento es de " + descuentoproducto2 + " si aplicamos el descuento, su total es de " + preciocondescuento2);
        }
        if (cantidadproducto3 <= 3)
        {
            Debug.Log("Su total es " + preciototal + " el descuento es de " + descuentoproducto3 + " si aplicamos el descuento, su total es de " + preciocondescuento3);
        }
        if (cantidadproducto1 <= 3 && cantidadproducto2 <= 3)
        {
            Debug.Log("Su total es " + preciototal + " el descuento es de " + descuentoproducto12 +  " si aplicamos el descuento, su total es de " + preciocondescuento12);
        }
        if (cantidadproducto1 <= 3 && cantidadproducto3 <= 3)
        {
            Debug.Log("Su total es " + preciototal + " el descuento es de " + descuentoproducto13 + " si aplicamos el descuento, su total es de " + preciocondescuento13);
        }
        if (cantidadproducto2 <= 3 && cantidadproducto3 <= 3)
        {
            Debug.Log("Su total es " + preciototal + " el descuento es de " + descuentoproducto23 + " si aplicamos el descuento, su total es de " + preciocondescuento23);
        }
        if (cantidadproducto2 <= 3 && cantidadproducto3 <= 3 && cantidadproducto1 <= 3)
        {
            Debug.Log("Su total es " + preciototal + " el descuento es de " + descuentoproducto123 + " si aplicamos el descuento, su total es de " + preciocondescuento123);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
