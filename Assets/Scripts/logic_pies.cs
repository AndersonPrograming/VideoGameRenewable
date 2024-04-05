using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class logic_pies : MonoBehaviour
{
    public Player_move player_move;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        player_move.puedoSaltar = true;
    }
    private void OnTriggerExit(Collider other)
    {
        player_move.puedoSaltar = false;
    }
}
