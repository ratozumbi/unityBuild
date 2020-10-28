using System;
using System.Linq;
using UnityEditor;
using UnityEngine;

class Editor: EditorWindow {
    
    
    static void Build() {

        // Place all your scenes here
        string[] scenes = {"Assets/scenes/c1.unity"};

        string pathToDeploy = "builds";
        string[] args = System.Environment.GetCommandLineArgs();

        string env = "";
        string target = "";
        for (int i = 0; i < args.Length; i++)
        {
            if (args[i] == "-environment")
            {
                env = args[i + 1];
            }

            if (args[i] == "-target")
            {
                target = args[i + 1];
            }
        }

        ConfigurationData newConfig = ScriptableObject.CreateInstance<ConfigurationData> ();

        if (env.Contains("dev"))
        {
            newConfig.ServerUrl = "Development";
        }
        
        // Game controller =Resources.FindObjectsOfTypeAll<Game>().First();

        // GameObject game = GameObject.FindGameObjectWithTag("GameController");
        // Game controller = game.GetComponent<Game>();
        
        // controller.SetEnv(env.Contains("dev") ? Game.CustomEnum.Dev : Game.CustomEnum.Prod);

        BuildPlayerOptions options = new BuildPlayerOptions();
        options.scenes = scenes;
        options.locationPathName = pathToDeploy;
        options.target = target.Contains("android") ? BuildTarget.Android : BuildTarget.StandaloneWindows64;
        BuildPipeline.BuildPlayer(options);
    }
}