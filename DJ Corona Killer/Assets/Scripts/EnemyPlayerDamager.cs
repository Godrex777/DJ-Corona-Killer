using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlayerDamager : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
       void OnCollisionEnter(Collision targetObj)
        {
            if (targetObj.gameObject.tag == "Enemy")
            {
                Destroy(targetObj.gameObject);
            }
        }
    }
}
