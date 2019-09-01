using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text roundstext;

    private void OnEnable()
    {
        roundstext.text = PlayerStats.Rounds.ToString();
    }

    public void Retry ()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
    }
}
