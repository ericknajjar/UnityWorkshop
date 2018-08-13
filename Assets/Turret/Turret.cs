using System.Collections;
using System.Collections.Generic;
using EasyInject.Engine.Runtime;
using EasyInject.IOC;
using EasyInject.IOC.extensions;
using UnityEngine;
using UniRx;

[HasBindings]
public class Turret : EntityComponent {

    [BindingProvider(DependencyCount = 2)]
    private static Turret GetTurret(IBindingContext creatorContext, IGameplayInput input,Vector2 position){
        
        var prefab = Resources.Load<Turret>("Turret/Turret");

        var go = GameObject.Instantiate(prefab.gameObject, position, Quaternion.identity);

        var turret = go.GetComponent<Turret>();
        var entityContext = turret.Entity.Context;

        entityContext.Bind<IGameplayInput>().To(input);
        entityContext.Bind<IBindingContext>().To(creatorContext);

        return turret;
    }


}
