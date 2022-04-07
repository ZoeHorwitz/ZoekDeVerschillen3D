
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 200f;

    public Camera fpsCam;
    private List list;
    // Update is called once per frame

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        list = FindObjectOfType<List>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        } 
    }

    public GameObject Shoot()
    {
        Ray ray = fpsCam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, range))
        {
            Debug.Log(hit.transform.name);
            if (list.goodObjects.Contains(hit.transform.gameObject))
            {
                Debug.Log("GOODOBJECT");
               
            }
            else if(hit.transform.gameObject.GetComponent<ClickCheck>() != null)
            {
                if (!hit.transform.gameObject.GetComponent<ClickCheck>().IsClicked)
                {
                    list.score.wrong++;
                    hit.transform.gameObject.GetComponent<ClickCheck>().IsClicked = true;
                }
              
                
            }
            return hit.transform.gameObject;
            //  Destroy(hit.transform.gameObject); // gebruik deze line om de accuracy te testen 

            // if hit.transform.gameObject goed is...
            // doe... bijvoorbeeld score verhogen

            // if hit.transform.gameObject fout is
            // doe... bijvoorbeeld min punten of kruis laten zien
        }
        return null;
    }   

}

// List<GameObject> goodObjects = new List<GameOject>();
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
