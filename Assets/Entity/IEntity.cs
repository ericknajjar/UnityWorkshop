using System.Collections;
using System.Collections.Generic;
using EasyInject.IOC;
using UnityEngine;

public interface IEntity
{
    IBindingContext Context { get; }
}
