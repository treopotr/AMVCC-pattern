using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine;


[InitializeOnLoad]
public class SceneGenerator
{
    static SceneGenerator()
    {

        EditorSceneManager.newSceneCreated += SceneCreating;

    }


    public static void SceneCreating(Scene scene, NewSceneSetup setup, NewSceneMode mode)
    {

        var cameraObject = Camera.main.transform;
        var lightObject = GameObject.Find("Directional Light").transform;


        var applicationFolder = new GameObject("[Application]").transform;
        var modelFolder = new GameObject("[Model]").transform;
        var viewFolder = new GameObject("[View]").transform;
        var controllerFolder = new GameObject("[Controller]").transform;


        modelFolder.parent = applicationFolder.transform;
        controllerFolder.parent = applicationFolder.transform;
        viewFolder.parent = applicationFolder.transform;

        
        var lights = new GameObject("Lights").transform;
        lightObject.parent = lights.transform;


        cameraObject.parent = viewFolder.transform;
        lights.parent = viewFolder.transform;





        //var lights = new GameObject("Lights").transform;
        //lightObject.parent = lights;


        //var cameras = new GameObject("Cameras").transform;
        //cameraObject.parent = cameras;

        //cameras.parent = applicationFolder;
        //lights.parent = applicationFolder;

        //var world = new GameObject("[WORLD]").transform;
        //new GameObject("Static").transform.parent = world;
        //new GameObject("Dynamic").transform.parent = world;


        //new GameObject("[UI]");

        Debug.Log("New scene created");

    }



}
