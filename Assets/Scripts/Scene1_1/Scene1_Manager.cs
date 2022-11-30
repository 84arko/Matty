using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Scene1_Manager : MonoBehaviour
{
    public Marco_Behavior[] marcos;
    public bool isUp;


    private void Start()
    {

    }
    public void SetIsup(bool val)
    {
        for (int i = 0; i < marcos.Length; i++)
        {
            marcos[i].SetUp(val);
        }
    }

}

