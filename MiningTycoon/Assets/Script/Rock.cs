using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    public int maxHP = 3;
    private int currentHP;
    public float respawnTime = 5f;

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
            //조건문 추가해서 확률적으로 다이아나 금도 나오게 할거임
            ResourceManager.Instance.AddIron(Random.Range(1,4));
            Break();
        }
    }

    void Break()
    {
        Debug.Log(gameObject.name + " 파괴됨");
        gameObject.SetActive(false);
        Invoke(nameof(Respawn), respawnTime);
    }

    void Respawn()
    {
        currentHP = maxHP;
        gameObject.SetActive(true);
    }
}
