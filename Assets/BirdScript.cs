using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public bool isActivated = false;
    public GController controlador;
    private float speed = 2.0f;
    private Vector2 target;

    // Start is called before the first frame update
    void Start()
    {
        controlador.delegadoTrampa += activate;
        target = new Vector2(0.0f, 0.40f);
    }

    // Update is called once per frame
    void Update()
    {
        if (isActivated)
        {
            float step = speed * Time.deltaTime;

            // move sprite towards the target location
            transform.position = Vector2.MoveTowards(transform.position, target, step);
        }
    }

    public void activate()
    {
        isActivated = true;
    }
}
