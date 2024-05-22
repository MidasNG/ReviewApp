using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clasificacion : MonoBehaviour
{
    public Transform tabla;
    public GameObject plantillaregistro;
    int cantidadRegistros;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("Crear tabla")]
    void CrearTabla()
    {
        for (int i = 0; i < cantidadRegistros; i++)
        {
            GameObject inst = Instantiate(plantillaregistro, tabla);
            inst.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, i * -70);
        }
    }
}
