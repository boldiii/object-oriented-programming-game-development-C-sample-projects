using UnityEngine;
public class Ogretmen : Ogrenci
{
    protected void Veri2(string ad1,string boy1,string ad2,string boy2)
    {
        Veri1(ad1, boy1);
        Debug.Log("Ogretmen adi ve Ogretmenin boyu: " + ad2 + boy2);
    }


}
