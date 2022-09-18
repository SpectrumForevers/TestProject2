using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    [SerializeField]
    private Text currentScoreText;
    int score, currentScore;

    private void OnTriggerEnter(Collider trigger)
    {
        if (trigger.gameObject.tag == "PickUp")
        {
            currentScore++;
            currentScoreText.text = "Pickuped: " + currentScore.ToString();
            trigger.gameObject.SetActive(false);
        }

        if (trigger.gameObject.tag == "House" && currentScore >= 5)
        {
            gameManager.ActivateObj();
        }

    }

}
