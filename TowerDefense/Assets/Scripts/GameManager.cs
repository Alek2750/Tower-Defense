using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool gameEnded = false;

    public GameObject gameOverUI;

    private void Update()
    {
        if (gameEnded)
            return;

        if (PlayerStats.Lives <=0)
        {
            EndGame();
        }
    }

    void EndGame ()
    {
        gameEnded = true;

        gameOverUI.SetActive(true);
    }
}
