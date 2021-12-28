using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour

    
{
    public string sceneNameToLoad;


    public void changeScene()
    {
        //  Application.loadedLevelName();
        SceneManager.LoadScene(sceneNameToLoad); // on change de scene

        //SceneManager.LoadScene(0);
    }
}
