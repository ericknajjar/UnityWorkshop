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
        #if (!UNITY_EDITOR && (UNITY_IPHONE || UNITY_ANDROID))
                m_input = new TouchInput();
        #endif

        #if (UNITY_EDITOR || UNITY_STANDALONE)
        m_input = new MouseInput();

        #endif
    }
	

	void Update () {
        
        if(m_input.Fire)
        {
            GameObject.Instantiate(m_bulletPrefab.gameObject, transform.position, Quaternion.identity);
        }
	}
}
