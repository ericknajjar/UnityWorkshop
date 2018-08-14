using UnityEngine;
using System.Collections;
using EasyInject.Engine.Runtime;
using System;
using UniRx;

[HasBindings]
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

    #if (UNITY_EDITOR || UNITY_STANDALONE)
    [BindingProvider(Singleton =true)]
    private static IGameplayInput GetInput()
    {
        return new MouseInput();
    }
    #endif
}
