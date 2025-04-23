using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UIManager : MonoBehaviour
{

    public TMP_InputField InputClave;
    public TextMeshProUGUI txtMensaje;

    string Clave = "Use Youre Illusion";
    // Start is called before the first frame update
    void Start()
    {
        txtMensaje.text = string.Empty;
    }

    public void ComprobarClaveIngresada()
    {
        string ClaveIngresada = InputClave.text;
        if (ClaveIngresada != Clave)
        {
            txtMensaje.text = "Acceso denegado";
            InputClave.text = "";
        }else
        {
            txtMensaje.text = "Bienvenido";
        }
    }
}
