using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveCubes : MonoBehaviour
{
    [SerializeField] private GameObject Bars;
 //   [SerializeField] private GameObject Cube;

  

    private void OnDestroy()
    {
        Destroy(Bars);
    }
}

