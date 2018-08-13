using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class TurretMovement : EntityComponent {

    [SerializeField]
    float m_movementSpeed = 0;

    Transform m_transform;

	void Start () {
        
        m_transform = transform;
        var input = Entity.Context.Get<IGameplayInput>();

        input.Movement.Subscribe((movement) => {
            Vector2 translation = movement * Time.deltaTime * Vector2.right * m_movementSpeed;
            m_transform.Translate(translation);
        });
	}

}
