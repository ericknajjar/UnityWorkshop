using UnityEngine;
using System.Collections;
using EasyInject.Engine.Runtime;
using System;
using UniRx;

[HasBindings]
public class MouseInput : IGameplayInput
{
    public IObservable<float> Movement
    {
        get
        {
            return Observable.EveryUpdate().Select((_) => Input.GetAxis("Mouse X")).Where(_ => Mathf.Abs(_) > 0.0f);
        }
    }

    public IObservable<Unit> Fire{
        get {
            return Observable.EveryUpdate().Where((_) => Input.GetButtonDown("Fire1")).Select((_) => Unit.Default);
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
