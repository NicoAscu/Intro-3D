using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClonaCubos : MonoBehaviour
{

    public GameObject cuboPreFab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ClonarCubos()
    {
        Instantiate(cuboPreFab);
    }

}
