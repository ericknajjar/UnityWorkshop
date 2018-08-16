using UnityEngine;
using System.Collections;
using EasyInject.Engine.Runtime;
using System;
using UniRx;

#if (!UNITY_EDITOR && (UNITY_IPHONE || UNITY_ANDROID))

[HasBindings]
public class TouchInput : IGameplayInput
{
    private TouchInput(){
        
    }

    public float Movement
    {
        get
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                // Get movement of the finger since last frame
                Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
                return Mathf.Clamp(touchDeltaPosition.x,-1.0f,1.0f);
            }

            return 0.0f;
        }
    }

    public bool Fire
    {
        get
        {
            return Input.touchCount > 1 && Input.GetTouch(1).phase == TouchPhase.Began;
       
        }
    }

    [BindingProvider(Singleton = true)]
    private static IGameplayInput Create(){
        return new TouchInput();
    }
}
#endif