using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoNextScene : MonoBehaviour
{

    public string scenename;

    public void OnSelect()
    {
        SceneManager.LoadScene(scenename);
    }
}
