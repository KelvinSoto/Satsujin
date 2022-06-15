using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelTran1 : MonoBehaviour
{
    public Vector3 change;

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D (Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            col.transform.position = new Vector3(change.x, change.y, change.z);

        }
    }
}
