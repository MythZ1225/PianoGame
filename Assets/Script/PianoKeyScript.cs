using UnityEngine;
using System.Collections;

public class PianoKeyScript : MonoBehaviour {

    //public float SemiToneOffset=0;

	// Use this for initialization
	void Start () {
        //
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnMouseDown()
    {
        AudioSource SE = GetComponent<AudioSource>();
        //SE.pitch = Mathf.Pow(2f, SemiToneOffset / 12.0f);
        SE.Play();
        gameObject.transform.Rotate(2, 0, 0);

        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.1f);    //注意等待时间的写法
        Debug.Log("Wait 0.1f");
        gameObject.transform.Rotate(-2, 0, 0);
    }

}
