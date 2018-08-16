using UnityEngine;
using System.Collections;

public static class InputSingleton
{
    private static IGameplayInput s_instance;

    public static IGameplayInput GetInstance(){
        
        if(s_instance == null){
            #if (!UNITY_EDITOR && (UNITY_IPHONE || UNITY_ANDROID))
            s_instance = new TouchInput();
            #endif

            #if (UNITY_EDITOR || UNITY_STANDALONE)
            s_instance = new MouseInput();
                
            #endif
        }

        return s_instance;
    }

}
