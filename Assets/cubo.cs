using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cubo : MonoBehaviour
{
    public GameObject cube;
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;

    public bool izquierda;
    public bool derecha;

    public Text nombre;

    private void Start()
    {
        nombre.text = PlayerPrefs.GetString("nombre");
    }
    void Update()
{
        //if (Input.GetKey(KeyCode.UpArrow))
        //    transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        //if (Input.GetKey(KeyCode.DownArrow))
        //    transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

        //if (Input.GetKey(KeyCode.LeftArrow))
        if (izquierda&&!derecha)
        {
            

            cube.transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
            derecha = false;
        }
        //else if (derecha)
        //{
        //    izquierda = false;

        //    cube.transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        //}


        ////if (Input.GetKey(KeyCode.RightArrow))
        if (derecha&&!izquierda)
        {
            

            cube.transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
            izquierda = false;
        }

    }

    public void activar()
    {
        izquierda = true;
    }
}
