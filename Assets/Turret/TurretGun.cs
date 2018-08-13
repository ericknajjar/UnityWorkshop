using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretGun : MonoBehaviour {

    [SerializeField]
    Bullet m_bulletPrefab;

	// Use this for initialization
	void Start () {
		
	}
	

	void Update () {
        
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject.Instantiate(m_bulletPrefab.gameObject, transform.position, Quaternion.identity);
        }
	}
}
