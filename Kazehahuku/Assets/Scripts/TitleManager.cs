using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class TitleManager : MonoBehaviour
{
    public void OnStartClickd(){
        SceneManager.LoadScene("PlayerTestScene");
    }
}
