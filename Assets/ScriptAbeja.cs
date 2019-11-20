using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptAbeja : MonoBehaviour
{
    public Transform objectToFollow;
    private Rigidbody2D rb;
    public float speed = 5.0f;
    public bool isActivated = false;
    public GController controlador;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        controlador.delegadoTrampa += activate;
    }

    // Update is called once per frame
    void Update()
    {
        if (isActivated && objectToFollow != null)
        {
            Vector3 newVector = objectToFollow.position - transform.position;
            newVector = Vector3.Normalize(newVector);
            rb.AddForce(newVector * speed);
        }
    }

    public void activate()
    {
        isActivated = true;
    }
}
