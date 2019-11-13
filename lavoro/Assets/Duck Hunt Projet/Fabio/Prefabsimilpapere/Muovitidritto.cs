using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muovitidritto : MonoBehaviour
{

    public float velocita = 5;
    public Vector3 rOffset;

    private void Update()
    {
        int SDuck = GetComponent<Duck>().vita;

        transform.localPosition += transform.forward * velocita * Time.deltaTime;

        if (SDuck > 0)
        {

            transform.localPosition += transform.forward * velocita * Time.deltaTime;

        }
        else
        {

            transform.localRotation = Quaternion.Euler(rOffset);
            transform.localPosition += transform.forward * velocita * Time.deltaTime;

        }
        

    }
}
