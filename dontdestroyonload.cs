using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dontdestroyonload : MonoBehaviour
{
    private static dontdestroyonload instance;

    private void Start()
    {
        if (!instance)
        {
            instance =this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    
    
}
