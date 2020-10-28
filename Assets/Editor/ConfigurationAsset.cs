using UnityEngine;
using UnityEditor;
 
public class ConfigurationAsset
{
    [MenuItem("Assets/Create/Server Configuration")]
    public static void CreateAsset ()
    {
        ScriptableObjectUtility.CreateAsset<ConfigurationData> ();
    }
}