using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HintScript : MonoBehaviour {
    public Image myPanel;
    public GameObject Text1;
    public GameObject Text2;
    float fadeTime = 2f;
    Color colorToFadeTo;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKeyDown)
        {
            colorToFadeTo = new Color(0f, 0f, 0f, 0f);
            myPanel.CrossFadeColor(colorToFadeTo, fadeTime, true, true);
            Text1.GetComponent<Text>().CrossFadeAlpha(0.0f, 2.0f, false);
            Text2.GetComponent<Text>().CrossFadeAlpha(0.0f, 2.0f, false);
        }
	}
}
