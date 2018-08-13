using System.Collections;
using System.Collections.Generic;
using EasyInject.IOC;
using UnityEngine;

public class Entity : MonoBehaviour, IEntity {

    private IBindingContext m_context;

    public IBindingContext Context {
        get {
            if (m_context == null)
                m_context = BindingContext.Create();

            return m_context;
        }
    }
	
}
