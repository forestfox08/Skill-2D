using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Byte : MonoBehaviour
{
    [SerializeField] Bit[] bits = new Bit[8];
    [SerializeField] int value = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Bin2Dec();  
    }

    private void Bin2Dec()
    {
        Debug.Log("wiwiwi");

        this.value = 0;
        //if (bits[0].state)
        {
           //this.
        }
    }
}
