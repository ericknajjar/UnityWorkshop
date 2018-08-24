using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretGun : EntityComponent {

    [SerializeField]
    Bullet m_bulletPrefab;

    IGameplayInput m_input;

	private void Start()
	{
        m_input = Entity.Context.Get<IGameplayInput>();
	}

	void Update () {
        
        if(m_input.Fire)
        {
            GameObject.Instantiate(m_bulletPrefab.gameObject, transform.position, Quaternion.identity);
        }
	}
}
