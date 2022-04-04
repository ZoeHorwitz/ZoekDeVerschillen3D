using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    public List<GameObject> goodObjects = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }


    
    // En die maak je public of [Serializable] en dan kan je in de inspector al die gameobjects daar in slepen
    // en dan zeg je bij regel 34 bijvoorbeeld:
    // foreach(gameobject object in goodObjects)
    // {
    //  if (object == hit.transform.gameObject)
    //  {
    //      dan geef je punten of whatever want dan is het aangeklikte object een goed object.
    //  }    
    //  else
    //  {
    //      hier kan je strafpunten of fout geven ofzo want dan is het aangeklikte object geen goed object.
    //  }
    // }

}
