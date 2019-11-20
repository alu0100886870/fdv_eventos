using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GController : MonoBehaviour
{
    public delegate void onTrampaActivada();
    public onTrampaActivada delegadoTrampa;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void trampaActivada()
    {
        Debug.Log("Trampa activada!");
        delegadoTrampa();
    }
}
