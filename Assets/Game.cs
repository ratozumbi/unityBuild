
using System;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Game:MonoBehaviour
{
    [Tooltip("Must be null before build.")]
    public static ConfigurationData configuration;

    private void Start()
    {
        if (configuration == null)
        {
            configuration = Resources.Load<ConfigurationData>("Config");    
        }
        
        FindObjectOfType<Text>().text = configuration.ServerUrl;
    }
    
}
