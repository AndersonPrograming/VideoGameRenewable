using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float alert;
    public LayerMask enemy;
    public Transform Player;
    public float speed;
    bool stayAlert;



    void Start()
    {

    }


    void Update()
    {
        stayAlert = Physics.CheckSphere(transform.position, alert, enemy);

        if (stayAlert == true)
        {
            transform.LookAt(Player);
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(Player.position.x, transform.position.y, Player.position.z), speed * Time.deltaTime);
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, alert);
    }
}
