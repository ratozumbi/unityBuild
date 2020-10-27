
using System;
using UnityEngine;
using UnityEngine.UI;

public class Game:MonoBehaviour
{
    public enum CustomEnum // your custom enumeration
    {
        Prod, 
        Dev
    };
    public CustomEnum dropDown = CustomEnum.Prod;  // this public var should appear as a drop down

    private void Start()
    {
        FindObjectOfType<Text>().text = dropDown == CustomEnum.Prod ? "Production" : "Development";
    }

    public void SetEnv(CustomEnum env)
    {
        dropDown = env;
        FindObjectOfType<Text>().text = dropDown == CustomEnum.Prod ? "Production" : "Development";
    }
}
