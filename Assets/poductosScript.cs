
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class poductosScript : MonoBehaviour
{
    public GameObject[] alimentos1;
    public GameObject[] alimentos2;
    public GameObject panel;
    public GameObject BotonResponder;



    public Text BotonSalir;
    public Text Txtprecio1;
    public Text Txtprecio2;
    public Text Txtresultado;
    public InputField InputRespuesta;

    int[] precios;

    int SumaPrecios;
    int respuesta;
    int nroR;
    int nroR2;








    // Start is called before the first frame update

    void Start()
    {
        DesactivarTodo();

        precios = new int[14];

        //precioPera = 5
        precios[0] = 5;
        //precioCHamburguesa = 15
        precios[1] = 15;
        //precioSandia = 9
        precios[2] = 9;
        //precioHuevo = 3
        precios[3] = 3;
        //precioSushi = 12
        precios[4] = 12;
        //precioBotella = 16
        precios[5] = 16;
        //precioHamburguesa = 10
        precios[6] = 10;
        //precioSandwich = 11
        precios[7] = 11;
        //precioBanana = 4
        precios[8] = 4;
        //precioZanahoria = 6
        precios[9] = 6;
        //precioHongo = 8
        precios[10] = 8;
        //precioMedialuna = 13
        precios[11] = 13;
        //precioLimon = 7
        precios[12] = 7;
        //precioSalchicha = 14
        precios[13] = 14;


        apariciondeprecios();

        panel.SetActive(false);
        BotonReiniciar();
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void apariciondeprecios()
    {
        nroR = Random.Range(0, 13);
        int precio1 = precios[nroR];
        Txtprecio1.text = precio1.ToString();

        nroR2 = Random.Range(0, 13);
        int precio2 = precios[nroR2];
        Txtprecio2.text = (precio2).ToString();

        SumaPrecios = precio1 + precio2;







    }

    void DesactivarTodo()
    {
        for (int i = 0; i < alimentos1.Length; i++)
        {
            alimentos1[i].SetActive(false);
        }

        for (int i = 0; i < alimentos2.Length; i++)
        {
            alimentos2[i].SetActive(false);
        }

        if (panel != null)
        {
            panel.SetActive(false);
        }
    }
    public void PanelInfo()
    {
        panel.SetActive(true);
        if(InputRespuesta.text != "")
        {
            respuesta = int.Parse(InputRespuesta.text);
        }
        else
        {
            BotonSalir.text = "Volver a intentarlo";
            Txtresultado.text = "Debes ingresar un resultado";
            return;
        }
        

        if (respuesta == SumaPrecios)
        {

            Txtresultado.text = "Respuesta correcta";
            BotonSalir.text = "Reiniciar el desafio";

        }
        else if (respuesta != SumaPrecios)
        {
            Txtresultado.text = "Respuesta incorrecta";
            BotonSalir.text = "Volver a intentarlo";

        }

        InputRespuesta.text = "";

        for (int i = 0; i < alimentos1.Length; i++)
        {
            alimentos1[i].SetActive(false);
        }

        for (int i = 0; i < alimentos2.Length; i++)
        {
            alimentos2[i].SetActive(false);
        }



    }

    public void BotonReiniciar()
    {


        if (respuesta == SumaPrecios)
        {

            BotonSalir.text = "Reiniciar el desafío";
            panel.SetActive(false);
            apariciondeprecios();
            AparicionObjetos();
        }


        else if (respuesta != SumaPrecios)
        {

            BotonSalir.text = "Volver a intentarlo";
            panel.SetActive(false);
            apariciondeprecios();
            AparicionObjetos();


        }
        else if (InputRespuesta.text == null)
        {
            BotonSalir.text = "Ingresar resultado";
            panel.SetActive(false);
            apariciondeprecios();
            AparicionObjetos();
        }

    }
    void AparicionObjetos()
    {
        alimentos1[nroR].SetActive(true);
        alimentos2[nroR2].SetActive(true);
    }

}



