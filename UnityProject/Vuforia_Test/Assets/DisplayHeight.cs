using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class DisplayHeight : MonoBehaviour
{

    public GameObject planeFinder;
    private Text textCmp;
    private PlaneFinderBehaviour planeCmp;

    // Start is called before the first frame update
    void Start()
    {
        textCmp = gameObject.GetComponent<Text>();
        planeCmp = planeFinder.GetComponent<PlaneFinderBehaviour>();

        
        textCmp.text = "AAA";
    }

    // Update is called once per frame
    void Update()
    {
        textCmp.text = planeCmp.Height.ToString();
    }
}
