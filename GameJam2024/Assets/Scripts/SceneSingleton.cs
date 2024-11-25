
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSingleton<T> : MonoBehaviour where T : SceneSingleton<T>
{
    public static T instance = null;

    protected virtual void Awake()
    {
        if(instance == null)
        {
            instance = this as T;
            DontDestroyOnLoad(this.gameObject);
            //Debug.Log("This happened");
        }
        else
        {
            Destroy(this.gameObject);
        }
    }






}