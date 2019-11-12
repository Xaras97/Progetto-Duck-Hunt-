using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muovitidritto : MonoBehaviour
{
    private void Update()
    {

        transform.localPosition += transform.up * Time.deltaTime;
    }
}
