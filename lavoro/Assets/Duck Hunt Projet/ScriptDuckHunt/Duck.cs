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
    public Animator anim;
    public GameObject movimento;

    public enum TIPI_DI_PAPERE
    {
        RIGHT_DUCK,
        WRONG_DUCK,
        BONUS_DUCK
    }

    public void Awake()
    {
        anim = GetComponent<Animator>();
        mirino = FindObjectOfType<Mirino>();
        head = GetComponentInChildren<DuckHead>();
        head.owner = this;
    }
    public void Danneggia(int damage)
    {
        vita -= damage;
        anim.SetTrigger("presa");

        if (vita <= 0)           
        {
           
            anim.SetTrigger("morta");
            this.gameObject.GetComponent<Collider>().isTrigger=true;
            head.GetComponent<Collider>().isTrigger = true;


            if (tipo == TIPI_DI_PAPERE.RIGHT_DUCK)
            {
                mirino.numeroPapere -= 1;
                levelManager.DuckCheck();

            }
            

        }
    }
   
}
