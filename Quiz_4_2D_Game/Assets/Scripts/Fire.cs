using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("FireBullet",0.3f,0.3f);
    }

    // Update is called once per frame
    void Update()
    {
      
        
    }
    public void FireBullet()
    {
        Instantiate(bullet,transform.position,bullet.transform.rotation);
    }
}
