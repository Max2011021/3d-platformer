using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tramplone : MonoBehaviour
{
    float jump = 6f;

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength *= jump;
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength /= jump;
    }
}
