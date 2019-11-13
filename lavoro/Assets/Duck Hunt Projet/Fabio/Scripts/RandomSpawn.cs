using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject[] PapereBonus = new GameObject[0];
    public GameObject[] PapereNormali = new GameObject[0];
    public GameObject[] PapereMalus = new GameObject[0];

    [Range(-360f,360f)]
    public float rangeMin = 0,rangeMax = 0;

    public float distanzaDalloSpawn = 5;

    public Vector3 direction,rotOffset;

    void SpawnaPapere()
    {

        int numeroacaso = Random.Range(0, 101);
        if (numeroacaso > 75)
        {

        }

    }

    void SpawnaPaperaBonus()
    {

        GameObject PaperaB = PapereBonus[Random.Range(0, PapereBonus.Length)];

        transform.rotation = Quaternion.Euler(Random.Range(rangeMin, rangeMax), 0, 0);

        GameObject PaperaBInstance = Instantiate(PaperaB,transform.up * distanzaDalloSpawn, Quaternion.Euler(transform.forward));

        PaperaBInstance.transform.localRotation = transform.rotation * Quaternion.Euler(rotOffset);
    }

    void SpawnaPaperaNormale()
    {

        GameObject PaperaN = PapereNormali[Random.Range(0, PapereNormali.Length)];

        transform.rotation = Quaternion.Euler(Random.Range(rangeMin, rangeMax), 0, 0);

        GameObject PaperaBInstance = Instantiate(PaperaN, transform.up * distanzaDalloSpawn, Quaternion.Euler(transform.forward));

        PaperaBInstance.transform.localRotation = transform.rotation * Quaternion.Euler(rotOffset);
    }

    void SpawnaPaperaMalus()
    {
        GameObject PaperaM = PapereBonus[Random.Range(0, PapereMalus.Length)];

        GameObject PaperaMInstance = Instantiate(PaperaM, transform.up * 5, Quaternion.Euler(transform.forward));

        PaperaMInstance.transform.localRotation = transform.rotation;

    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnaPaperaBonus();
        }
        transform.eulerAngles = direction;
    }

}
