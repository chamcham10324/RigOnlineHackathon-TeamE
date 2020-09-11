using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FontScalable : MonoBehaviour
{
	[Range(1, 6)]
	public float fontScale = 1;
	TextMesh tetxMesh;

    // Start is called before the first frame update
    void Start()
    {
        tetxMesh = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        int fontSize = Mathf.Max(12, tetxMesh.fontSize);
		tetxMesh.fontSize = fontSize;
		float scale = 0.1f * 128 / fontSize;
		tetxMesh.characterSize = scale * fontScale;
    }
}
