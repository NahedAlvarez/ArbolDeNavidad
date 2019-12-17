using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class Arbol : MonoBehaviour
{
    public int n = 10;
    string stars;
    int oldI = 0;
    List<string> treeStrings = new List<string>();
    string path1 = @"C:\programs\file.txt";

    void Start()
    {
        for (int i = 0; i <= n; i++)
        {
            for (int j = 0; j <= n - i-1; j++)
            {
                stars += "-";

            }
            for (int k = 0; k <= i+oldI; k++)
            {
                stars += "*";
            }
            treeStrings.Add(stars);
            Debug.Log(stars);
            stars = string.Empty;
            oldI = i+1;
        }

        for (int i = 0; i < 2; i++)
        {
            for (int k = 0; k < (n-1); k++)
            {
                stars += "-";
            }
            stars += "***";
            treeStrings.Add(stars);
            Debug.Log(stars);
            stars = string.Empty;
        }

        FileStream fsOverwrite = new FileStream("C:\\Users\\NAHED\\Desktop\\file.txt", FileMode.Create);
        StreamWriter swOverwrite = new StreamWriter(fsOverwrite);

        foreach (string item in treeStrings)
        {
            swOverwrite.WriteLine(item);
        }
        swOverwrite.Close();

    }

    


}