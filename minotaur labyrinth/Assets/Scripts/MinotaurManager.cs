using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinotaurManager : MonoBehaviour
{
    public int MinotaurCount;
    public List<GameObject> Minotaurs;    // Start is called before the first frame update
    void Start()
    {
        MinotaurCount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void AddMinotaur()
    {
        Minotaurs[MinotaurCount].SetActive(true) ;
        MinotaurCount++;
    }
}
