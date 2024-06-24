using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Calculadora : MonoBehaviour
{
    public TMP_InputField primerNum;
    public TMP_InputField segundoNum;
    public TMP_Text resultadotext;
    public int resultado;

    public void Suma()
    {
        int numero1 = int.Parse(primerNum.text);
        int numero2 = int.Parse(segundoNum.text);

        resultado = numero1 + numero2;
        resultadotext.text = resultado.ToString();
    }
    public void Resta()
    {
        int numero1 = int.Parse(primerNum.text);
        int numero2 = int.Parse(segundoNum.text);

        resultado = numero1 - numero2;
        resultadotext.text = resultado.ToString();
    }
    public void Multiplicacion()
    {
        int numero1 = int.Parse(primerNum.text);
        int numero2 = int.Parse(segundoNum.text);

        resultado = numero1 * numero2;
        resultadotext.text = resultado.ToString();
    }
    public void Division()
    {
        int numero1 = int.Parse(primerNum.text);
        int numero2 = int.Parse(segundoNum.text);

        resultado = numero1 / numero2;
        resultadotext.text = resultado.ToString();
    }

}
