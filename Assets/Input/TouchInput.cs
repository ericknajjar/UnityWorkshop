using UnityEngine;
using System.Collections;
using EasyInject.Engine.Runtime;
using System;
using UniRx;

[HasBindings]
public class TouchInput : IGameplayInput
{
    private TouchInput()
    {

    }

    public IObservable<float> Movement
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    public IObservable<Unit> Fire
    {

        get
        {
            throw new NotImplementedException();
        }
    }

    #if ( !UNITY_EDITOR && (UNITY_IPHONE || UNITY_ANDROID))
    [BindingProvider(Singleton =true)]
    private static IGameplayInput GetInput()
    {
        return new TouchInput();
    }
    #endif
}
