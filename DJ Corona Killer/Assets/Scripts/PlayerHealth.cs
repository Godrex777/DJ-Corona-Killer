using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public static int currentHealth;
    public Text healthText;
    
    
    
    void Start()
    {
        currentHealth = maxHealth;
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(1);
        }
        healthText.text = currentHealth.ToString();
        if (currentHealth == 0)
        {
            SceneManager.LoadScene("lost");
        }
        
    }

    
    
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }

    void OnCollisionEnter(Collision targetObj)
    {
        if(targetObj.gameObject.tag == "Enemy")
        {
            currentHealth = currentHealth - 1;
        }
    }

    
}
