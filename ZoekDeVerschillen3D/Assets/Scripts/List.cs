using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    public List<GameObject> goodObjects = new List<GameObject>();
    [SerializeField] private Gun gun;
    public Score score;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CheckClicks();
          
        }
    }
    private void CheckClicks ()
        {
        for (int i = 0; i < goodObjects.Count; i++)
        {
            if(gun.Shoot() == goodObjects[i] && !goodObjects[i].GetComponent<ClickCheck>().IsClicked)
            {
                score.score++;
                goodObjects[i].GetComponent<ClickCheck>().IsClicked = true;
                return;
                
         
            }
            //if(gun.Shoot() != goodObjects[i] )
           // {
            //    score.wrong++;

            //    return;
            //}
        }
       
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
