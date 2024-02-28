using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class printcommand : MonoBehaviour
{

    /*Instanzvariable:*/
    int i = 0;
    string[] array1 = new string[3];
    string[] array2;

    void Start()
    {
        Debug.Log("Hello World!");
        Debug.Log("Instanzvariable i :" + i);


        //Lokale Variable
        int result = i + 1;
        Debug.Log("Lokale Variable result: " + result);

        NochEineLokaleVariable();
        BefuelleArray();
        PrintArray(array1);
        array2 = BefuelleArray("d", "e", "f", new string[3]);
        PrintArray(array2);

        Debug.Log(array1);
    }

    void BefuelleArray()
    {
        array1[0] = "a";
        array1[1] = "b";
        array1[2] = "c";
    }

    string[] BefuelleArray(string a, string b, string c, string[] array)
    {
        array[0] = a;
        array[1] = b;
        array[2] = c;
        return array;
    }

    void PrintArray(string[] a)
    {
        for(int i = 0; i < a.Length; i++)
        {
            Debug.Log(a[i]);
        }
    }

    void NochEineLokaleVariable()
    {
        int result = i + 1;

    }

}


