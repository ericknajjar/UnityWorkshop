using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretGun : MonoBehaviour {

    [SerializeField]
    Bullet m_bulletPrefab;

    IGameplayInput m_input;

    // Use this for initialization
    void Start()
    {
        m_input = InputSingleton.GetInstance();
    }
	

	void Update () {
        
        if(m_input.Fire)
        {
            GameObject.Instantiate(m_bulletPrefab.gameObject, transform.position, Quaternion.identity);
        }
	}
}
