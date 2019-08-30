using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Vuforia;


public class ChangeHeight : MonoBehaviour
{

    public float value;
    
    public GameObject planeFinder;
    private PlaneFinderBehaviour planeCmp;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(AddValue);
        
        planeCmp = planeFinder.GetComponent<PlaneFinderBehaviour>();
    }

    void AddValue(){
        planeCmp.Height += value;
    }

    
}
