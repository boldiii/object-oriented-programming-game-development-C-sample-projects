using UnityEngine;
using Veri1;            //diğer scriptteki namespacemizi bu şekilde çağırıp ,
public class NameSpaceCagirma : MonoBehaviour
{
    dusman dusman = new dusman();   // bu şekilde başlatmamız gerekiyor.

    void Start()
    {
        dusman.saglik();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}