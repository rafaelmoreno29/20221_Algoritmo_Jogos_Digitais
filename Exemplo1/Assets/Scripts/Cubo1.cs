using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo1 : MonoBehaviour
{
    [SerializeField]
    float velocidade;
    [SerializeField]
    bool direita = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 15)
            direita = false;
        else if (transform.position.x < -15)
            direita = true;

        if(direita)
            transform.Translate(new Vector3(1,0,0) * Time.deltaTime * velocidade);
        else
            transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * velocidade);
    }
}
