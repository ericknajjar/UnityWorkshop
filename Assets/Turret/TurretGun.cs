using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class TurretGun : EntityComponent {

    [SerializeField]
    Bullet m_bulletPrefab;

	// Use this for initialization
	void Start () {
		    
        var input = Entity.Context.Get<IGameplayInput>();

        input.Fire.Subscribe((Unit) => {
            GameObject.Instantiate(m_bulletPrefab.gameObject, transform.position, Quaternion.identity);
        });
	}


}
