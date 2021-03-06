﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretMovement : EntityComponent {

    [SerializeField]
    float m_movementSpeed;

    IGameplayInput m_input;

    Transform m_transform;

	void Start () {
        m_transform = transform; 
        m_input = Entity.Context.Get<IGameplayInput>();
	}

	void Update () {

        Vector2 translation = m_input.Movement * Time.deltaTime * Vector2.right * m_movementSpeed;
        m_transform.Translate(translation);

	}
}
