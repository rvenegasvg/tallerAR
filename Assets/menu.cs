using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public InputField input;
    public string escena;




    public void setNombre()
    {

        string n = input.text;

        if (string.IsNullOrEmpty(n))
        {
            Debug.Log("valor nulo");
        }
        else
        {
            Debug.Log("el nombre es: "+n);
            PlayerPrefs.SetString("nombre",n);
            SceneManager.LoadScene(escena);
        }



    }


}
