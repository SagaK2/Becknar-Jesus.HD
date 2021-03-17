using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{
    //poäng variabel (som egentligen bara är tiden + summan av poäng man får av items). JR
    public int Points;
    //kollar ifall den ska börja räkna eller inte. JR
    private bool tidscheck;
    //texten för ui. JR
    public Text Tidräknare;
    // Start is called before the first frame update
    void Start()
    {
        //tid ska passera så fort spelet startas. JR
        tidscheck = true;
       
    }
    // en till variabel för poängen kommer inte ihåg varför men skriptet funkar inte utan denna!. JR
    float score = 0.0f;
    // Update is called once per frame
    void Update()
    {
        //score = sekunderna som passerat. JR
        score += Time.deltaTime;
        //omvandla poängen till int. JR 
        Points = (int)score;
        //det som visas ska vara variabeln "Points". JR
        DisplayTime(Points);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Ifall man rör ett hinder så dör man och då ska tiden stoppas. JR
        tidscheck = false;
    }
    //Den ska visa den visuella tiden (den utan en massa decimaler som datorn har när den räknar). JR
    void DisplayTime(float visualTime)
    {
        //konverterar float till int så det inte blir en massa konstiga siffror. JR
        float seconds = Mathf.FloorToInt(visualTime);
        //lägg till tiden som text i poängssystemet i detta formatet. JR
        Tidräknare.text = string.Format("{0}", seconds);
    }
}
