using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    
    private void OnCollisionEnter(Collision collision)

    {

        if (collision.gameObject.CompareTag("Bullet"))
        {


            Debug.Log("ENEMY GET SHOOTED");

            GameObject.FindGameObjectWithTag("Player").GetComponent<Shooting>().EnemyKilled();

            Destroy(collision.gameObject);

            Destroy(this.gameObject);


        }

        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(2);
        }

      
        
    }
    
    
}

