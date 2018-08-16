using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretMovement : MonoBehaviour {

    [SerializeField]
    float m_movementSpeed;

    public IGameplayInput m_input;

    Transform m_transform;

	void Start () {
        m_transform = transform; 
	}

	void Update () {

        Vector2 translation = m_input.Movement * Time.deltaTime * Vector2.right * m_movementSpeed;
        m_transform.Translate(translation);

	}
}
