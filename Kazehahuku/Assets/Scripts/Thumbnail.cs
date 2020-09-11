using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Thumbnail : MonoBehaviour
{
    public int Flag;
    int OldFlag;

    Image MainSpriteRenderer;
    // publicで宣言し、inspectorで設定可能にする
    public Sprite Stage1;
    public Sprite Stage2;
    public Sprite Stage3;
    public Sprite Stage4;
    public Sprite Stage5;

    void Start()
    {
        Flag = 0;
        OldFlag = 0;
        // このobjectのSpriteRendererを取得
        MainSpriteRenderer = gameObject.GetComponent<Image>();
    }

    void Update() {
        if (OldFlag != Flag) {
            if (Flag == 1) MouseOnStage1();
            else if (Flag == 2) MouseOnStage2();
            else if (Flag == 3) MouseOnStage3();
            else if (Flag == 4) MouseOnStage4();
            else if (Flag == 5) MouseOnStage5();

            OldFlag = Flag;
        }
    }

    void MouseOnStage1()
    {
        MainSpriteRenderer.sprite = Stage1;
    }
    void MouseOnStage2()
    {
        MainSpriteRenderer.sprite = Stage2;
    }
    void MouseOnStage3()
    {
        MainSpriteRenderer.sprite = Stage3;
    }
    void MouseOnStage4()
    {
        MainSpriteRenderer.sprite = Stage4;
    }
    void MouseOnStage5()
    {
        MainSpriteRenderer.sprite = Stage5;
    }
}