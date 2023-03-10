using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    private void OnCollisionEnter(Collision collision)
    {
        if(!collision.gameObject.CompareTag("Untagged"))
        {

            if (collision.gameObject.tag == "Bullet")
            { 
                SceneManager.LoadScene("GameOver");

            }

            if (collision.gameObject.tag == "Fruit")
            {
                score++;
                Destroy(collision.gameObject);
                scoreText.text = "Score: " + score.ToString();

            }
        }

        
    }

}
