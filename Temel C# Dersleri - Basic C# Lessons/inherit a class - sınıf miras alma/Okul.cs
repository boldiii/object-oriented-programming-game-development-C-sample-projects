using UnityEngine;

public class Okul : Ogretmen
{
    public void TumVeri(string ad1, string boy1, string ad2, string boy2,string okulad)
    {
        Veri2(ad1, boy1, ad2, boy2);
        Debug.Log("Okulun adi: " + okulad);
    }



 }
