using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void MovetoScene(int SceneID)
    {
        SceneManager.LoadScene(SceneID);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
