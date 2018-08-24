using System.Collections;
using System.Collections.Generic;
using EasyInject.Engine.Runtime;
using EasyInject.IOC.extensions;
using UnityEngine;
using UniRx;

[HasBindings]
public class Turret : EntityComponent {


    [BindingProvider(DependencyCount = 1)]
    private static Turret CreateInstance(IGameplayInput input, Vector2 pos){
        var prefab = Resources.Load<Turret>("Turret/Turret");

        var go = GameObject.Instantiate(prefab.gameObject, pos, Quaternion.identity);

        var turret = go.GetComponent<Turret>();

        turret.Entity.Context.Bind<IGameplayInput>().To(input);

        return turret;
    }

}
