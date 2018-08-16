using System.Collections;
using System.Collections.Generic;
using EasyInject.Engine.Runtime;
using UnityEngine;
using UniRx;

[HasBindings]
public class Turret : MonoBehaviour {


    [BindingProvider(DependencyCount = 1)]
    private static Turret CreateInstance(IGameplayInput input, Vector2 pos){
        var prefab = Resources.Load<Turret>("Turret/Turret");

        var go = GameObject.Instantiate(prefab.gameObject, pos, Quaternion.identity);

        go.GetComponent<TurretGun>().m_input = input;
        go.GetComponent<TurretMovement>().m_input = input;

        return go.GetComponent<Turret>();
    }

}
