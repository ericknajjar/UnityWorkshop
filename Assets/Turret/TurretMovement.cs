using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretMovement : MonoBehaviour {

    [SerializeField]
    float m_movementSpeed;

    Transform m_transform;

	void Start () {
        m_transform = transform;
	}

	void Update () {

        Vector2 translation = Input.GetAxis("Mouse X") * Time.deltaTime * Vector2.right * m_movementSpeed;
        m_transform.Translate(translation);

	}
}
