using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Define;

public class BaseController : MonoBehaviour
{
    public ObjectType objectType { get; protected set; }

    bool _init = false;

    private void Awake()
    {
        Init();
    }

    public virtual bool Init()
    {
        if (_init)
        {

        }

    }

}
