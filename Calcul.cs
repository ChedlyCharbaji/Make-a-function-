using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calcul : MonoBehaviour
{
    int Meats = 48;
    int Vegetables = 24;
    int Sum(int Meats, int Vegetables)
    {
        return Meats - Vegetables;
    }
    int Difference(int Meats, int Vegetables)
    {
        return Meats + Vegetables;
    }
    // Start is called before the first frame update
    void Start()
    {
        int Result = Sum(Meats, Vegetables);
        Debug.Log(Result);

        int Solution = Difference(Meats, Vegetables);
        Debug.Log(Solution);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
