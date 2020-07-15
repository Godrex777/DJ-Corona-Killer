using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sc : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        void OnCollisionEnter(Collision targetObj)
        {
            if (targetObj.gameObject.tag == "Player DJ")
            {
                SceneManager.LoadScene("won");
            }
        }
    }
}
