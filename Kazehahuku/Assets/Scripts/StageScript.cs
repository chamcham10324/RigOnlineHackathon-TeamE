using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageScript : MonoBehaviour
{
    public Thumbnail TS;
    public int register;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MouseOver() 
    {
        TS.Flag = register;
    }

    public void SelectStage() {
        SceneManager.LoadScene("Stage" +register);
    }
}
