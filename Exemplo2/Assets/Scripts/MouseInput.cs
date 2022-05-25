using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
    [SerializeField]
    GameObject cubo;
    [SerializeField]
    float velocidade = 10;

    void Start()
    {        
    }
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Debug.Log("Mouse Down left " + Input.mousePosition);
        //}
        if(Input.GetMouseButton(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = (mousePosition -
                        new Vector2(cubo.transform.position.x, cubo.transform.position.y)
                        ).normalized;
            
            cubo.transform.Translate(direction * Time.deltaTime * velocidade);
        }
        //if (Input.GetMouseButtonUp(0))
        //{
        //    Debug.Log("Mouse Up left " + Input.mousePosition);
        //}
    }
}
