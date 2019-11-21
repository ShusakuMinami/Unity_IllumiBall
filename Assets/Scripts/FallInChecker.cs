using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallInChecker : MonoBehaviour
{
    public Hole red;
    public Hole blue;
    public Hole green;
    
    void OnGUI()
    {
        string label = "";
        
        // 全てのボールが入ったらラベルを表示
        if(red.IsFallIn() && blue.IsFallIn() && green.IsFallIn())
        {
            label = "Fall In Hole!";
        }
        GUI.Label(new Rect(0, 0, 100, 30), label);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
