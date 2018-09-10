using System.Collections;
using System.Collections.Generic;
using EasyInject.Engine.Runtime;
using EasyInject.IOC.extensions;
using UnityEngine;
using UniRx;
using EasyInject.IOC;

[HasBindings]
public class Turret : EntityComponent {


    [BindingProvider(DependencyCount = 1)]
    private static Turret CreateInstance(IBindingContext context, Vector2 pos){
        var prefab = Resources.Load<Turret>("Turret/Turret");

        var go = GameObject.Instantiate(prefab.gameObject, pos, Quaternion.identity);

        var turret = go.GetComponent<Turret>();

        turret.Entity.Context.FallBack(context);

        return turret;
    }

}
