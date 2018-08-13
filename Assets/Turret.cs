using System.Collections;
using System.Collections.Generic;
using EasyInject.Engine.Runtime;
using UnityEngine;
using UniRx;

[HasBindings]
public class Turret : MonoBehaviour {

    [BindingProvider(DependencyCount = 1)]
    private static Turret GetTurret(IGameplayInput input,Vector2 position){
        
        var prefab = Resources.Load<Turret>("Turret");

        var go = GameObject.Instantiate(prefab.gameObject, position, Quaternion.identity);

        var turret = go.GetComponent<Turret>();

        input.Movement.Subscribe((movement) =>
        {
            go.transform.Translate(Vector3.right * movement * 5 * Time.deltaTime);
        });

        return turret;
    }


}
