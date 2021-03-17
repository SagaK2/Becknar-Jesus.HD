using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{
    public int Points;
    private bool tidscheck;
    public Text siffra;
    // Start is called before the first frame update
    void Start()
    {
        tidscheck = true;
       
    }

    float score = 0.0f;
    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime;
        Points = (int)(score);
        DisplayTime(Points);
    }

    private void OnTriggerEnter(Collider other)
    {
        tidscheck = false;
    }
    void DisplayTime(float visualTime)
    {
        visualTime += 1;
        //float minutes = Mathf.FloorToInt(visualTime / 60);
        float seconds = Mathf.FloorToInt(visualTime);
        siffra.text = string.Format("{0}", seconds);
    }
}
