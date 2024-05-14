using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridItem : MonoBehaviour
{
    public Button button;
    public Text buttonText;

    private GameController gameController;

    public void SetText()
    {
        buttonText.text = gameController.GetCurrentPlayer();
        button.interactable = false;
        gameController.EndCurrentTurn();
    }

    public void SetGameController(GameController controller)
    {
        gameController = controller;
    }
}
