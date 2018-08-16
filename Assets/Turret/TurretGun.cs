using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretGun : MonoBehaviour {

    [SerializeField]
    Bullet m_bulletPrefab;

    public IGameplayInput m_input;

	void Update () {
        
        if(m_input.Fire)
        {
            GameObject.Instantiate(m_bulletPrefab.gameObject, transform.position, Quaternion.identity);
        }
	}
}
