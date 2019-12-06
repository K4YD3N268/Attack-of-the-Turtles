using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string scene;
    Numofenemies myClass;

    private void Start()
    {
        myClass = FindObjectOfType<Numofenemies>();
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(scene);
    }

    void Update()
    {
        if (myClass)
        {
           if (myClass.numofenemies <= 0)
            {
                SceneManager.LoadScene(scene);
            }
        }
    }
}
