using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class CandyScript : MonoBehaviour
{

    private int food = 0;

    //[SerializeField] private Text foodText;

    public Text foodText;
    //text field will contain food object, that will be updated

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Food")
        {
            SoundManager.playEatSound();

            food++;

            Debug.Log("Food: " + food);


            foodText.text = "Food: " + food;
            //update


            ResetPosition(collision.gameObject);



            PlayerPrefs.SetInt("FoodCount", food);

        }
    }

    void ResetPosition(GameObject foodObject)
    {
        float randomX = Random.Range(-9f, 7.0f);
        float randomY = Random.Range(-4f, 4.0f);
        float randomRotation = Random.Range(0f, 360f);

        foodObject.transform.position = new Vector2(randomX, randomY);
        foodObject.transform.rotation = Quaternion.Euler(0f, 0f, randomRotation);
    }
}
