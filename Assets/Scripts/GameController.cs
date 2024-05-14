using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text[] buttonsList;
    private string currentPlayerText;

    public GameObject gameOverPanel;

    public Text gameOverText;

    private int moveCount;

    private void Awake()
    {
        SetGCReference();
        currentPlayerText = "X";
        gameOverPanel.SetActive(false);
        moveCount = 0;
    }

    void SetGCReference()
    {
        for (int i = 0; i < buttonsList.Length; i++)
        {
            buttonsList[i].GetComponentInParent<GridItem>().SetGameController(this);
        }
    }

    public void EndCurrentTurn()
    {
        moveCount++;

        if (buttonsList[0].text == currentPlayerText && buttonsList[1].text == currentPlayerText && buttonsList[2].text == currentPlayerText)
        {
            GameOver();
        }
        if (buttonsList[3].text == currentPlayerText && buttonsList[4].text == currentPlayerText && buttonsList[5].text == currentPlayerText)
        {
            GameOver();
        }
        if (buttonsList[6].text == currentPlayerText && buttonsList[7].text == currentPlayerText && buttonsList[8].text == currentPlayerText)
        {
            GameOver();
        }
        if (buttonsList[0].text == currentPlayerText && buttonsList[3].text == currentPlayerText && buttonsList[6].text == currentPlayerText)
        {
            GameOver();
        }
        if (buttonsList[1].text == currentPlayerText && buttonsList[4].text == currentPlayerText && buttonsList[7].text == currentPlayerText)
        {
            GameOver();
        }
        if (buttonsList[2].text == currentPlayerText && buttonsList[5].text == currentPlayerText && buttonsList[8].text == currentPlayerText)
        {
            GameOver();
        }
        if (buttonsList[0].text == currentPlayerText && buttonsList[4].text == currentPlayerText && buttonsList[8].text == currentPlayerText)
        {
            GameOver();
        }
        if (buttonsList[2].text == currentPlayerText && buttonsList[4].text == currentPlayerText && buttonsList[6].text == currentPlayerText)
        {
            GameOver();
        }
        if (moveCount >= 9)
        {
            gameOverPanel.SetActive(true);
            gameOverText.text = "Its a draw!";
        }
        ChangePlayer();
    }

    public string GetCurrentPlayer()
    {
        return currentPlayerText;
    }

    public void ChangePlayer()
    {
        currentPlayerText = (currentPlayerText == "X") ? "O" : "X";
    }

    public void GameOver()
    {
        for (int i = 0; i < buttonsList.Length; i++)
        {
            buttonsList[i].GetComponentInParent<Button>().interactable = false;
        }

        gameOverPanel.SetActive(true);
        gameOverText.text = currentPlayerText + " Wins!";
        // Debug.Log(currentPlayerText + " Wins!");
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
