using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : BaseController
{
    public float Timer = 2.0f;


    // Update is called once per frame
    public void Update()
    {
        Timer -= Time.deltaTime;

        if(Timer <= 0)
        {
            Timer = 2.0f;
            //Manager.Object.Despawn(this);
        }
    }
}
