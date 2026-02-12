using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    public int maxHP = 3;
    private int currentHP;

    private Inventory inventory;

    private void Awake()
    {
        inventory = FindObjectOfType<Inventory>();
    }

    void Start()
    {
        currentHP = maxHP;
    }

    public void TakeDamage(int damage)
    {
        currentHP -= damage;

        Debug.Log(gameObject.name + " HP: " + currentHP);

        if (currentHP <= 0)
        {
            inventory.AddIron(Random.Range(1,4));
            Break();
        }
    }

    void Break()
    {
        Debug.Log(gameObject.name + " ÆÄ±«µÊ!");
        Destroy(gameObject);
    }
}
