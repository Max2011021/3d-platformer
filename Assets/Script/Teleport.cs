using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Vector3 teleportpoint;
    public Transform player;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.E))

    {
            player.transform.position = teleportpoint;
     
        
        }
    }







}
