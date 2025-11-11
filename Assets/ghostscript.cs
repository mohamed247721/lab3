using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostscript : EnemyController
{
    
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent <SpriteRenderer>();
    }
    
    void OnTriggerEnter2D (Collider2D other)
{
    if (other.tag == "Player")
    {
        FindObjectOfType<PlayerStats>().TakeDamage(damage);

    }

}
     // Update is called once per frame
    void Update()
    {
    
      }
    
}
    
