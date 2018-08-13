
using UnityEngine;
using UnityEngine.UI;
using EasyInject.IOC;
using EasyInject.IOC.extensions;
using System.Reflection;
using UniRx;



public class Bootstrap : MonoBehaviour {

  
    IBindingContext m_context;

    // Use this for initialization
    void Start()
    {
        var assembly = Assembly.GetAssembly(typeof(Bootstrap));
        var provider = new EasyInject.Engine.Runtime.ReflectiveBindingFinder(true,new Assembly[] { assembly });
        var factory = new EasyInject.Engine.Runtime.ReflectiveBindingContextFactory(provider);

        m_context = factory.CreateContext();

        //var up = UniRx.Observable.EveryUpdate().Where((u)=> Input.GetKeyDown(KeyCode.KeypadPlus)).Select((u)=> true);
        //var down = UniRx.Observable.EveryUpdate().Where((u) => Input.GetKeyDown(KeyCode.KeypadMinus)).Select((u) => false);

       // m_context.Get<Turret>();

        m_context.Get<Turret>(InnerBindingNames.Empty,Vector2.zero);
    }




}
