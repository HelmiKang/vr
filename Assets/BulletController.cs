using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField]
    float force = 500;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent <Rigidbody>().AddForce(transform.forward*force, ForceMode.Impulse);
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "enemy")
        {
                Destroy(this.gameObject);
        }

    }
}
