using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityComponent : MonoBehaviour {

    private IEntity m_entity;

    public IEntity Entity {
        get {
            if(m_entity==null) {
                m_entity = GetComponent<IEntity>();

                if (m_entity == null)
                    m_entity = GetComponentInParent<IEntity>();
            }

            return m_entity;
                
        }
    }
}
