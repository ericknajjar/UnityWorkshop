using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyInject.Engine.Runtime;
using UniRx;

public interface IInvader 
{
    
}

public enum InvaderValues
{
    Speed
}

[HasBindings]
public class Invader : MonoBehaviour, IInvader
{

  
    [BindingProvider(DependencyCount = 1, DependencieNames = new object[] { InvaderValues.Speed})]
    private static IInvader CreateInvader(System.IObservable<float> animationSpeed) {


        var prefab = Resources.Load<Invader>("Invader");
        var go = GameObject.Instantiate(prefab.gameObject);

        var invader = go.GetComponent<Invader>();
        var animator = invader.GetComponent<Animator>();
        var rigidBody = go.GetComponent<Rigidbody2D>();

        animationSpeed.TakeUntilDestroy(go).Subscribe((val) => {
            animator.speed = val;
            rigidBody.velocity = Vector2.down * 10 * val;
         });


        Observable.CombineLatest(animationSpeed, Observable.EveryFixedUpdate().Select((u)=> 0.0f)).TakeUntilDestroy(go).Subscribe((values) => { 
            
        });
                  


        return invader;
    }
}
