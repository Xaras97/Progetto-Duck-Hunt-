using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : MonoBehaviour
{
    public int vita = 2;
    public TIPI_DI_PAPERE tipo;
    private DuckHead head;
    public LevelManager levelManager;
    public Mirino mirino;

    public enum TIPI_DI_PAPERE
    {
        RIGHT_DUCK,
        WRONG_DUCK,
        BONUS_DUCK
    }

    public void Awake()
    {
        mirino = FindObjectOfType<Mirino>();
        head = GetComponentInChildren<DuckHead>();
        head.owner = this;
    }
    public void Danneggia(int damage)
    {
        vita -= damage;
        if (vita <= 0)
        {
            gameObject.SetActive(false);
            if(tipo == TIPI_DI_PAPERE.RIGHT_DUCK)
            {
                mirino.numeroPapere -= 1;
                levelManager.DuckCheck();

            }
            

        }
    }
   
}
