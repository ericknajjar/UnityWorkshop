using UnityEngine;
using System.Collections;
using EasyInject.Engine.Runtime;
using System;
using UniRx;

#if (UNITY_EDITOR || UNITY_STANDALONE)
[HasBindings]
public class MouseInput : IGameplayInput
{
    private MouseInput(){
        
    }

    public float Movement
    {
        get
        {
            return Mathf.Clamp(Input.GetAxis("Mouse X"), -1,1);
        }
    }

    public bool Fire {
        get {
            return Input.GetButtonDown("Fire1");
        }
    }

    [BindingProvider(Singleton = true)]
    private static IGameplayInput Create(){
        return new MouseInput();
    }
              
}

#endif