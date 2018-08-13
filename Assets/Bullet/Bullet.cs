using UnityEngine;
using EasyInject.Engine.Runtime;
using System.Collections;

public interface IBullet {
    
}

public class Bullet : MonoBehaviour, IBullet
{

    [SerializeField]
    float m_speed = 5.0f;

    [SerializeField]
    float m_lifeTime = 3.0f;

	private IEnumerator Start()
	{
        yield return new WaitForSeconds(m_lifeTime);
        Destroy(gameObject);
	}

	void Update()
    {
        transform.Translate(Vector3.up * m_speed * Time.deltaTime);
    }
}
