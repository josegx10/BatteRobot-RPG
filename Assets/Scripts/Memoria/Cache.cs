using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cache : MonoBehaviour
{
    public static Cache cache;
    private void Awake()
    {
        if (cache == null)
        {
            cache = this;
            DontDestroyOnLoad(gameObject);
        }else if (cache != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
