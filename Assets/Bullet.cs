using UnityEngine;
using EasyInject.Engine.Runtime;


public interface IBullet {
    
}

public enum BulletTypes 
{
    Green,Blue, Stealth
}

[HasBindings]
public class NonMonoBullet: IBullet {

    private NonMonoBullet() 
    {
        Debug.Log("Nào sou um mono behaviour");
    }

    [BindingProvider(Name = BulletTypes.Stealth)]
    private static IBullet GreenBullet()
    {
        return new NonMonoBullet();
    }

}

[HasBindings]
public class Other {

    [BindingProvider(Name = "TheString", DependencyCount = 1, DependencieNames = new object[]{"MagicNumber"})]
    private static string TheString(int val){
        Debug.Log("Chamei");
        return "Its working! "+val;
    }

}

[HasBindings]
public class Bullet : MonoBehaviour, IBullet
{
    int damgae;
    private static IBullet GreenBullet()
    {
        var prefab = Resources.Load<Bullet>("GreenBullet");

        var go = GameObject.Instantiate(prefab.gameObject);

        var b = go.GetComponent<Bullet>();

        return b;
    }

    [BindingProvider(DependencyCount = 1, DependencieNames = new object[] { "BulletType"})]
    private static IBullet createBullet(BulletTypes currentBulletType, int damge){
        
        if(BulletTypes.Green == currentBulletType)
        {
            return GreenBullet();
        } else {
            return BlueBullet();
        }
    }

  
    private static IBullet BlueBullet()
    {
        var prefab =  Resources.Load<Bullet>("BlueBullet");
        var go =  GameObject.Instantiate(prefab.gameObject);

        var b = go.GetComponent<Bullet>();
        return b;
    }

    void Update()
    {
        transform.Translate(Vector3.up * 5 * Time.deltaTime);
    }
}
