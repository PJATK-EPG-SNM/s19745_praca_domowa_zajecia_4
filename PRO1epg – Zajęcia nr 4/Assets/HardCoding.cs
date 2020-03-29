using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardCoding : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 10;
        float b = 1.5f;
        bool logiczna = true;
        bool nie = false;
        string pierwszy = "Programuję w C#";
        string drugi = "EPG";
        Debug.Log("a: " + a + " logiczna: " + logiczna + " nie: " + nie + "pierwszy:" + pierwszy + "drugi:" + drugi);

        if (a == b)
        {
            Debug.Log("Tak, są równe!");
        }
        else
        {
            Debug.Log("Nie");
        }
        if (a!=b)
        {
            Debug.Log("Tak, są różne");
        }
         else
        {
            Debug.Log("Nie");
        }
        if (a>b)
        {
            Debug.Log("Tak, a jest większe od b");
        }
        else
        {
            Debug.Log("Nie");
        }
        if (a >= b)
        {
            Debug.Log("Tak, a jest większe lub równe b");
        }
        else
        {
            Debug.Log("Nie");
        }
        if (a < b)
        {
            Debug.Log("Tak, a jest mniejsze od b");
        }
        else
        {
            Debug.Log("Nie");
        }
        if (a <= b)
        {
            Debug.Log("Tak, a jest mniejsze lub równe b");
        }
        else
        {
            Debug.Log("Nie");
        }

       if (pierwszy.Equals(drugi))
        {
            Debug.Log("takie same");
        }
        else
        {
            Debug.Log("różne");
        }


        if ((logiczna && nie) == true)
        {
            Debug.Log("True");
        }
        else if ((logiczna || nie) == false)
        {
            Debug.Log("false");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
