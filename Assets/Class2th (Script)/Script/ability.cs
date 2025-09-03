using System;
using UnityEngine;

public class ability 
{

    public ability( )
    {
        Debug.Log("능력이 활성화 되었습니다");
    }
    public int strength = 5;
    void Start()
    {

        Debug.Log("Strength : " +  strength);
    }


}
