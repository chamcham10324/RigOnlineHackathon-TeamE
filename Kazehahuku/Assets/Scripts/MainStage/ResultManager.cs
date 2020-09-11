using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultManager : MonoBehaviour
{
    //[SerializeField] Image starImage;
    [SerializeField] SpriteRenderer resultFrame;
    [SerializeField] Text result;
    [SerializeField] Text clear;
    [SerializeField] Text clearNumber;
    [SerializeField] Text damage;
    [SerializeField] Text damageNumber;
    [SerializeField] Text operation;
    [SerializeField] Text operationNumber;
    [SerializeField] Text evaluation;
    [SerializeField] GameObject star1;
    [SerializeField] GameObject star2;
    [SerializeField] GameObject star3;
    [SerializeField] GameObject grayStar1;
    [SerializeField] GameObject grayStar2;
    [SerializeField] GameObject grayStar3;
    [SerializeField] GameObject stageSelectButton;
    [SerializeField] Text stageSelectText;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //resultFrame.color -= new Color(0, 0, 0, 0.01f);
    }

    public void ResultStart(string timeText, float damageText, float operationText, float score)
    {
        iTween.ValueTo(gameObject, iTween.Hash("from", 0, "to", 1, "time", 1.5f, "delay", 0, "onupdate", "FadeinFrame"));
        iTween.ValueTo(gameObject, iTween.Hash("from", 0, "to", 1, "time", 0.5f, "delay", 1.5, "onupdate", "ResultText"));
        iTween.ValueTo(gameObject, iTween.Hash("from", 0, "to", 1, "time", 0.5f, "delay", 2, "onupdate", "ClearTime"));
        iTween.ValueTo(gameObject, iTween.Hash("from", 0, "to", 1, "time", 0.5f, "delay", 2.5, "onupdate", "ClearTimeNumber"));
        iTween.ValueTo(gameObject, iTween.Hash("from", 0, "to", 1, "time", 0.5f, "delay", 3, "onupdate", "Damage"));
        iTween.ValueTo(gameObject, iTween.Hash("from", 0, "to", 1, "time", 0.5f, "delay", 3.5, "onupdate", "DamageNumber"));
        iTween.ValueTo(gameObject, iTween.Hash("from", 0, "to", 1, "time", 0.5f, "delay", 4, "onupdate", "Operation"));
        iTween.ValueTo(gameObject, iTween.Hash("from", 0, "to", 1, "time", 0.5f, "delay", 4.5, "onupdate", "OperationNumber"));
        iTween.ValueTo(gameObject, iTween.Hash("from", 0, "to", 1, "time", 0.5f, "delay", 5, "onupdate", "Evaluation"));
        iTween.ValueTo(gameObject, iTween.Hash("from", 0, "to", 1, "time", 0.5f, "delay", 7, "onupdate", "StageSelect"));

        if(score < 80)
        {
            iTween.ValueTo(gameObject, iTween.Hash("from", 0, "to", 360, "time", 0.5f, "delay", 5.5, "onupdate", "RotateStar1"));
            iTween.ValueTo(gameObject, iTween.Hash("from", 0.3, "to", 0.15, "time", 0.5f, "delay", 5.5, "onupdate", "MoveStar1"));
        }
        if(score < 60)
        {
            iTween.ValueTo(gameObject, iTween.Hash("from", 0, "to", 360, "time", 0.5f, "delay", 6, "onupdate", "RotateStar2"));
            iTween.ValueTo(gameObject, iTween.Hash("from", 0.3, "to", 0.15, "time", 0.5f, "delay", 6, "onupdate", "MoveStar2"));
        }
        if(score < 40)
        {
            iTween.ValueTo(gameObject, iTween.Hash("from", 0, "to", 360, "time", 0.5f, "delay", 6.5, "onupdate", "RotateStar3"));
            iTween.ValueTo(gameObject, iTween.Hash("from", 0.3, "to", 0.15, "time", 0.5f, "delay", 6.5, "onupdate", "MoveStar3"));
        }

        clearNumber.text = timeText;
        damageNumber.text = damageText.ToString();
        operationNumber.text = operationText.ToString();
    }

    void FadeinFrame(float value)
    {
        resultFrame.color = new Color(1, 1, 1, value);
    }

    void ResultText(float value)
    {
        result.color = new Color(0, 0, 0, value);
    }

    void ClearTime(float value)
    {
        clear.color = new Color(0, 0, 0, value);
    }

    void ClearTimeNumber(float value)
    {
        clearNumber.color = new Color(0, 0, 0, value);
    }

    void Damage(float value)
    {
        damage.color = new Color(0, 0, 0, value);
    }

    void DamageNumber(float value)
    {
        damageNumber.color = new Color(0, 0, 0, value);
    }

    void Operation(float value)
    {
        operation.color = new Color(0, 0, 0, value);
    }

    void OperationNumber(float value)
    {
        operationNumber.color = new Color(0, 0, 0, value);
    }

    void Evaluation(float value)
    {
        evaluation.color = new Color(0, 0, 0, value);
        grayStar1.SetActive(true);
        grayStar2.SetActive(true);
        grayStar3.SetActive(true);
    }

    void RotateStar1(float value)
    {
        star1.SetActive(true);
        star1.transform.rotation = Quaternion.Euler(0, 0, value);
    }

    void MoveStar1(float value)
    {
        star1.transform.localScale = new Vector3(value, value, value);
    }

    void RotateStar2(float value)
    {
        star2.SetActive(true);
        star2.transform.rotation = Quaternion.Euler(0, 0, value);
    }

    void MoveStar2(float value)
    {
        star2.transform.localScale = new Vector3(value, value, value);
    }

    void RotateStar3(float value)
    {
        star3.SetActive(true);
        star3.transform.rotation = Quaternion.Euler(0, 0, value);
    }

    void MoveStar3(float value)
    {
        star3.transform.localScale = new Vector3(value, value, value);
    }

    void StageSelect(float value)
    {
        stageSelectButton.SetActive(true);
        stageSelectText.color = new Color(0, 0, 0, value);
    }

    public void ClickStageSelectButton()
    {
        SceneManager.LoadScene("StageSelectScene");
    }
}
