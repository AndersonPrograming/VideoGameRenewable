using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{

    // variables para movimiento
    public float velocidadMovimiento = 5.0f;
    public float velocidadRotacion = 200.0f;
    private Animator anim;
    public float x, y;

    //variables para jump
    public Rigidbody rb;
    public float fuerzaSalto = 10f;
    public bool puedoSaltar;


    // Start is called before the first frame update
    void Start()
    {
        puedoSaltar = false;
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        // Movimiento
        transform.Rotate(0, x * velocidadRotacion * Time.deltaTime, 0);
        transform.Translate(0, 0, y * velocidadMovimiento * Time.deltaTime);

    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");


        // Animaciones
        anim.SetFloat("velX", x);
        anim.SetFloat("velY", y);

        // Salto
        if (puedoSaltar)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetBool("salte", true);
                rb.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode.Impulse);
            }
            anim.SetBool("tocoSuelo", true);
        }
        else
        {
            estoyCayendo();
        }
    }

    public void estoyCayendo()
    {
        anim.SetBool("tocoSuelo", false);
        anim.SetBool("salte", false);
    }
}
