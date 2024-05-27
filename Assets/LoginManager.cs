using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    public InputField inputContra;
    string contra = "hola123";

    public void Verificacion()
    {

        if (inputContra.text == contra)
        {
            Debug.Log("Access granted.");
        } 
        else
        {
            Debug.Log("Access denied.");
        }
    }

    
}
