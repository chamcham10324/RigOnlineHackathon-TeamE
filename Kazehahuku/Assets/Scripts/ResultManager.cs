using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //resultFrame.color -= new Color(0, 0, 0, 0.01f);
    }

    public void ResultStart()
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
        //iTween.ValueTo(gameObject, iTween.Hash("from", 0, "to", 1, "time", 0.5f, "delay", 5.5, "onupdate", ""));

        iTween.ValueTo(gameObject, iTween.Hash("from", 0, "to", 360, "time", 0.5f, "delay", 5.5, "onupdate", "RotateStar1"));
        iTween.ValueTo(gameObject, iTween.Hash("from", 0.1, "to", 0.05, "time", 0.5f, "delay", 5.5, "onupdate", "MoveStar1"));
        iTween.ValueTo(gameObject, iTween.Hash("from", 0, "to", 360, "time", 0.5f, "delay", 6, "onupdate", "RotateStar2"));
        iTween.ValueTo(gameObject, iTween.Hash("from", 0.1, "to", 0.05, "time", 0.5f, "delay", 6, "onupdate", "MoveStar2"));
        iTween.ValueTo(gameObject, iTween.Hash("from", 0, "to", 360, "time", 0.5f, "delay", 6.5, "onupdate", "RotateStar3"));
        iTween.ValueTo(gameObject, iTween.Hash("from", 0.1, "to", 0.05, "time", 0.5f, "delay", 6.5, "onupdate", "MoveStar3"));
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
}
