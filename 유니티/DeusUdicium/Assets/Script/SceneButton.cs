using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButton : MonoBehaviour
{

    public int target_scene = 0;

    public void SceneChange()
    {
        SceneManager.LoadScene(target_scene, LoadSceneMode.Single);
    }

}
