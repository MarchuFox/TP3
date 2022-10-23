using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Enemy : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
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

        if (collision.gameObject.CompareTag("Item"))
        {
            Destroy(collision.gameObject);
            {
                SceneManager.LoadScene(3);
            }

        }

        

        
    }
}

