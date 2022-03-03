using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ScaleCapsule : MonoBehaviour
{
    public float scale;
    public Scrollbar scrollbar;

    void Start()
    {
        //Cache the Slider variables
        scrollbar = GameObject.Find("Scrollbar").GetComponent<Scrollbar>();
    }

    void OnEnable()
    {
        //Subscribe to the Slider Click event
        scrollbar.onValueChanged.AddListener(delegate { scrollbarCallBack(scrollbar.value); });
    }

    //Will be called when Slider changes
    public void scrollbarCallBack(float value)
    {
        Debug.Log("Scrollbar Changed: " + value);
        scale = scrollbar.value;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.localScale = new Vector3(scale, scale, scale);
    }

}
