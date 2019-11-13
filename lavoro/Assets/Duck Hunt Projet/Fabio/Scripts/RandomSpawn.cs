using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject[] PapereBonus = new GameObject[0];
    public GameObject[] PapereNormali = new GameObject[0];
    public GameObject[] PapereMalus = new GameObject[0];

    [Range(-360f, 360f)]
    public float rangeMin = 0,rangeMax = 0;

    public float distanzaDalloSpawn = 5;

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

        Debug.Log(this.transform.rotation.x);

        PaperaBInstance.transform.LookAt(PaperaBInstance.transform.position + transform.up, Vector3.up);

    }

    void SpawnaPaperaNormale()
    {

        GameObject PaperaN = PapereNormali[Random.Range(0, PapereNormali.Length)];

        transform.rotation = Quaternion.Euler(Random.Range(rangeMin, rangeMax), 0, 0);

        GameObject PaperaNInstance = Instantiate(PaperaN, transform.up * distanzaDalloSpawn, Quaternion.Euler(transform.forward));

        PaperaNInstance.transform.LookAt(PaperaNInstance.transform.position + transform.up, Vector3.up);
    }

    void SpawnaPaperaMalus()
    {
        GameObject PaperaM = PapereMalus[Random.Range(0, PapereMalus.Length)];

        transform.rotation = Quaternion.Euler(Random.Range(rangeMin, rangeMax), 0, 0);

        GameObject PaperaMInstance = Instantiate(PaperaM, transform.up * distanzaDalloSpawn, Quaternion.Euler(transform.forward));

        PaperaMInstance.transform.LookAt(PaperaMInstance.transform.position + transform.up, Vector3.up);

    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnaPaperaBonus();
        }

    }

}
