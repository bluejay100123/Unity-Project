using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressAnyKey : MonoBehaviour
{
    // Start is called before the first frame update
    public void SceneChange()
    {
        SceneManager.LoadScene("LoadScene");
    }

    void Update()
    {
        if(Input.anyKeyDown)
        {
            SceneChange();
        }
    }
}
