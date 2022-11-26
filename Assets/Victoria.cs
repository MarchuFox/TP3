using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Victoria : MonoBehaviour
{


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Bullet"))
        {
            
            Destroy(collision.gameObject);

            Destroy(this.gameObject);

            SceneManager.LoadScene(3);
        }
    }




}

