using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uglyController : MonoBehaviour
{

    private void OnCollisionEnter(Collision other) {
        Destroy(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
