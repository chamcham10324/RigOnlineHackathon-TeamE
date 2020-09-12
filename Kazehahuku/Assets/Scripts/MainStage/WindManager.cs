using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindManager : MonoBehaviour
{
    private AreaEffector2D windEffector;
    [SerializeField] GameObject windEffect1;
    [SerializeField] GameObject windEffect2;
    private Image wim1;
    private Image wim2;

    void Start()
    {
        windEffector = GetComponent<AreaEffector2D>();
        wim1 = windEffect1.GetComponent<Image>();
        wim2 = windEffect2.GetComponent<Image>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            windEffector.forceAngle = 90;
            windEffect1.transform.rotation = Quaternion.Euler(0, 0, 90);
            windEffect2.transform.rotation = Quaternion.Euler(0, 0, 90);
            windEffect1.transform.position = new Vector3(Screen.width * Random.Range(0f, 1f), Screen.height * Random.Range(0f, 1f), 0);
            windEffect2.transform.position = new Vector3(Screen.width * Random.Range(0f, 1f), Screen.height * Random.Range(0f, 1f), 0);
            iTween.ValueTo(gameObject, iTween.Hash("from", 0, "to", 1, "time", 0.3f, "delay", 0, "onupdate", "WindUp"));
            iTween.ValueTo(gameObject, iTween.Hash("from", 1, "to", 0, "time", 0.3f, "delay", 0.3, "onupdate", "WindUpa"));
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            windEffector.forceAngle = 270;
            windEffect1.transform.rotation = Quaternion.Euler(0, 0, -90);
            windEffect2.transform.rotation = Quaternion.Euler(0, 0, -90);
            windEffect1.transform.position = new Vector3(Screen.width * Random.Range(0f, 1f), Screen.height * Random.Range(0f, 1f), 0);
            windEffect2.transform.position = new Vector3(Screen.width * Random.Range(0f, 1f), Screen.height * Random.Range(0f, 1f), 0);
            iTween.ValueTo(gameObject, iTween.Hash("from", 0, "to", 1, "time", 0.3f, "delay", 0, "onupdate", "WindDown"));
            iTween.ValueTo(gameObject, iTween.Hash("from", 1, "to", 0, "time", 0.3f, "delay", 0.3, "onupdate", "WindDowna"));
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            windEffector.forceAngle = 180;
            windEffect1.transform.rotation = Quaternion.Euler(0, 0, 0);
            windEffect2.transform.rotation = Quaternion.Euler(0, 0, 0);
            windEffect1.transform.position = new Vector3(Screen.width * Random.Range(0f, 1f), Screen.height * Random.Range(0f, 1f), 0);
            windEffect2.transform.position = new Vector3(Screen.width * Random.Range(0f, 1f), Screen.height * Random.Range(0f, 1f), 0);
            iTween.ValueTo(gameObject, iTween.Hash("from", 0, "to", 1, "time", 0.3f, "delay", 0, "onupdate", "WindLeft"));
            iTween.ValueTo(gameObject, iTween.Hash("from", 1, "to", 0, "time", 0.3f, "delay", 0.3, "onupdate", "WindLefta"));
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            windEffector.forceAngle = 0;
            windEffect1.transform.rotation = Quaternion.Euler(0, 0, 180);
            windEffect2.transform.rotation = Quaternion.Euler(0, 0, 180);
            windEffect1.transform.position = new Vector3(Screen.width * Random.Range(0f, 1f), Screen.height * Random.Range(0f, 1f), 0);
            windEffect2.transform.position = new Vector3(Screen.width * Random.Range(0f, 1f), Screen.height * Random.Range(0f, 1f), 0);
            iTween.ValueTo(gameObject, iTween.Hash("from", 0, "to", 1, "time", 0.3f, "delay", 0, "onupdate", "WindRight"));
            iTween.ValueTo(gameObject, iTween.Hash("from", 1, "to", 0, "time", 0.3f, "delay", 0.3, "onupdate", "WindRight"));
        }
    }

    void WindUp(float value)
    {
        wim1.color = new Color(1, 1, 1, value);
        wim2.color = new Color(1, 1, 1, value);
        windEffect1.transform.position += new Vector3(0, 3 * value, 0);
        windEffect2.transform.position += new Vector3(0, 3 * value, 0);
    }

    void WindUpa(float value)
    {
        wim1.color = new Color(1, 1, 1, value);
        wim2.color = new Color(1, 1, 1, value);
    }

    void WindDown(float value)
    {
        wim1.color = new Color(1, 1, 1, value);
        wim2.color = new Color(1, 1, 1, value);
        windEffect1.transform.position += new Vector3(0, -3 * value, 0);
        windEffect2.transform.position += new Vector3(0, -3 * value, 0);
    }

    void WindDowna(float value)
    {
        wim1.color = new Color(1, 1, 1, value);
        wim2.color = new Color(1, 1, 1, value);
    }

    void WindLeft(float value)
    {
        wim1.color = new Color(1, 1, 1, value);
        wim2.color = new Color(1, 1, 1, value);
        windEffect1.transform.position += new Vector3(-3 * value, 0, 0);
        windEffect2.transform.position += new Vector3(-3 * value, 0, 0);
    }

    void WindLefta(float value)
    {
        wim1.color = new Color(1, 1, 1, value);
        wim2.color = new Color(1, 1, 1, value);
    }

    void WindRight(float value)
    {
        wim1.color = new Color(1, 1, 1, value);
        wim2.color = new Color(1, 1, 1, value);
        windEffect1.transform.position += new Vector3(3 * value, 0, 0);
        windEffect2.transform.position += new Vector3(3 * value, 0, 0);
    }

    void WindRighta(float value)
    {
        wim1.color = new Color(1, 1, 1, value);
        wim2.color = new Color(1, 1, 1, value);
    }
}
