using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombBird : Bird
{
    public GameObject explosion;

    // Start is called before the first frame update
    public override void OnCrash()
    {
        GameObject tempExp = Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(tempExp,0.2f);
        Destroy(gameObject);
    }
}
