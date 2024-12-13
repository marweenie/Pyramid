using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class QuitManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Quit()
    {
        if (Application.isPlaying & !Application.isEditor)
            Application.Quit(); // We may return from this, but the program will terminate at the end of the frame
        #if false
        else
            UnityEditor.EditorApplication.isPlaying = false;    // Handle being in the editor, but set #if to true to use it
        #endif
    }
}
