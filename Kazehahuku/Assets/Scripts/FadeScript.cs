using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class FadeScript : MonoBehaviour
{
    public GameObject button;
    float alfa;    //A値を操作するための変数
    float red, green, blue;    //RGBを操作するための変数
    Image im;

    void Start () {
    }

    public void Fadeout () {    
        
        im = GetComponent<Image>();
        iTween.ValueTo(gameObject, iTween.Hash("from", 0, "to", 1, "time", 3.0f, "delay", 0, "onupdate", "FadeinFrame"));
        // Debug.Log("clicked");
        // button.SetActive(false);
        Invoke("LS", 3f);

    }


void FadeinFrame(float value)
    {
        im.color = new Color(0, 0, 0, value);
    }

    public void LS(){
        SceneManager.LoadScene("PlayerTestScene");
    }

}
