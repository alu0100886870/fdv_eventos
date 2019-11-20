using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampaScript : MonoBehaviour
{

    public GameObject controlador;
    private GController script;

    // Start is called before the first frame update
    void Start()
    {
        script = controlador.GetComponent<GController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        script.trampaActivada();
    }
}
