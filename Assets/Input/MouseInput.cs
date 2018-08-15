using UnityEngine;
using System.Collections;
using EasyInject.Engine.Runtime;
using System;
using UniRx;

public class MouseInput : IGameplayInput
{
    public float Movement
    {
        get
        {
            return Input.GetAxis("Mouse X");
        }
    }

    public bool Fire {
        get {
            return Input.GetButtonDown("Fire1");
        }
    }

}
