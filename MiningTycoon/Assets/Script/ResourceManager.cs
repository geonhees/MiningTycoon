using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public int ironCount = 0;
    //int goldCount = 0; 
    //int diamondCount = 0; 나중에 쓸거
    public static ResourceManager Instance;
    private ResourceUI resourceUI;

    private void Awake()
    {
        Instance = this;
        resourceUI = FindObjectOfType<ResourceUI>();
    }

    public void AddIron(int count) //나중에 랜덤테이블 써서 금이나 다이아같은거 추가하는거 어떻게 만들어보고싶음
    {
        ironCount += count;
        Debug.Log("철광석 " + count + "개 획득!"); 

        resourceUI.UpdateUI(ironCount);
    }
    public int RemoveIron(int amount)
    {
        int removed = Mathf.Min(ironCount, amount);
        ironCount -= removed;
        return removed;
    }
}
