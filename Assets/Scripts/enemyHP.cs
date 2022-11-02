using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHP : MonoBehaviour
{
    private float hp = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet")
        {
            hp -= 25;
            Debug.Log(hp);
            if(hp<=0)
              {
                this.gameObject.SetActive(false);
                Destroy(this.gameObject);
                Destroy(other.gameObject);
              }
            
        }
            
    }
}
