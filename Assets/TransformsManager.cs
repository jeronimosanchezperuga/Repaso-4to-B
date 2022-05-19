using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformsManager : MonoBehaviour
{
    public GameObject myCube;
    public GameObject rotado;
    public GameObject escalado;
    public GameObject rotadoYEscalado;
    public Vector3 originalRotation;
    public Vector3 originalScale;
    public bool isRotated;

    void Start()
    {
        isRotated = false;
        originalRotation = myCube.transform.eulerAngles;
        originalScale = myCube.transform.localScale;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (isRotated)
            {
                myCube.transform.eulerAngles = originalRotation;
                isRotated = false;
            }
            else
            {
                myCube.transform.eulerAngles = rotado.transform.eulerAngles;
                isRotated = true;
            }            
        }
    }
}
