using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int numberOfPlayers;

    private int totalRedInHouse, totalGreenInhouse, totalBlueInHouse, totalYellowInHouse;

    public GameObject frameRed, frameGreen, frameYellow, frameBlue;

    public GameObject redPlayer1Border, redPlayer2Border, redPlayer3Border, redPlayer4Border;
    public GameObject greenPlayer1Boreder, greenPlayer2Boreder, greenPlayer3Boreder, greenPlayer4Boreder;
    public GameObject bluePlayer1Border, bluePlayer2Border, bluePlayer3Border, bluePlayer4Border;
    public GameObject yellowPlayer1Border, yellowPlayer2Border, yellowPlayer3Border, yellowPlayer4Border;

    public Vector3 redPlayer1Pos, redPlayer2Pos, redPlayer3Pos, redPlayer4Pos;
    public Vector3 greenPlayer1Pos, greenPlayer2Pos, greenPlayer3Pos, greenPlayer4Pos;
    public Vector3 bluePlayer1Pos, bluePlayer2Pos, bluePlayer3Pos, bluePlayer4Pos;
    public Vector3 yellowPlayer1Pos, yellowPlayer2Pos, yellowPlayer3Pos, yellowPlayer4Pos;

    public Transform diceRoll;
    public Transform redDiceRoll, greenDiceroll, blueDiceRoll, yellowDiceRoll;

     public Button diceRollButton;

    public Button redPlayer1Button, redPlayer2Button, redPlayer3Button, redPlayer4Button;
    public Button greenPlayer1Button, greenPlayer2Button, greenPlayer3Button, greenPlayer4Button;
    public Button bluePlayer1Button, bluePlayer2Button, bluePlayer3Button, bluePlayer4Button;
    public Button yellowPlayer1Button, yellowPlayer2Button, yellowPlayer3Button, yellowPlayer4Button;

    public GameObject blueScreen, greenScreen, yellowScreen, redScreen;

    private string playerTurn = "RED";
    private string currentPlayer = "none";
    private string currentPlayerName = "none";

    //Player Movement Controller
    public GameObject redPlayer1, redPlayer2, redPlayer3, redPlayer4;
    public GameObject bluePlayer1, bluePlayer2, bluePlayer3, bluePlayer4;
    public GameObject yellowPlayer1, yellowPlayer2, yellowPlayer3, yellowPlayer4;
    public GameObject greenPlayer1, greenPlayer2, greenPlayer3, greenPlayer4;

    public int redPlayer1Steps, redPlayer2Steps, redPlayer3Steps, redPlayer4Steps;
    public int bluePlayer1Steps, bluePlayer2Steps, bluePlayer3Steps, bluePlayer4Steps;
    public int greenPlayer1Steps, greenPlayer2Steps, greenPlayer3Steps, greenPlayer4Steps;
    public int yellowPlayer1Steps, yellowPlayer2Steps, yellowPlayer3Steps, yellowPlayer4Steps;

    private int selectDiceNumAnimation;

    public GameObject dice1RollAnimation, dice2RollAnimation, dice3RollAnimation,
                       dice4RollAnimation, dice5RollAnimation, dice6RollAnimation;

    public List<GameObject> redMovementBlock = new List<GameObject>();
    public List<GameObject> greenMovementBlock = new List<GameObject>();
    public List<GameObject> yellowMovementBlock = new List<GameObject>();
    public List<GameObject> blueMovementBlock = new List<GameObject>();

    private System.Random randNo;

    private void IntializeDice()
    {
        diceRollButton.interactable = true;

        dice1RollAnimation.SetActive(false);
        dice2RollAnimation.SetActive(false);
        dice3RollAnimation.SetActive(false);
        dice4RollAnimation.SetActive(false);
        dice5RollAnimation.SetActive(false);
        dice6RollAnimation.SetActive(false);

        switch (numberOfPlayers)
        {
            case 2: 
                if(playerTurn == "RED")
                {
                    diceRoll.position = redDiceRoll.position;
                    frameRed.SetActive(true);
                    frameGreen.SetActive(false);
                }

                if(playerTurn == "GREEN") 
                {
                    diceRoll.position = greenDiceroll.position;
                    frameRed.SetActive(false);
                    frameGreen.SetActive(true);
                }

                redPlayer1Button.interactable = false;
                redPlayer2Button.interactable = false;
                redPlayer3Button.interactable = false;
                redPlayer4Button.interactable = false;

                greenPlayer1Button.interactable = false;
                greenPlayer2Button.interactable = false;
                greenPlayer3Button.interactable = false;
                greenPlayer4Button.interactable = false; 

                redPlayer1Border.SetActive(false);
                redPlayer2Border.SetActive(false);
                redPlayer3Border.SetActive(false);
                redPlayer4Border.SetActive(false);

                greenPlayer1Boreder.SetActive(false);
                greenPlayer2Boreder.SetActive(false);
                greenPlayer3Boreder.SetActive(false);
                greenPlayer4Boreder.SetActive(false);

                break;

            case 3:
                if(playerTurn == "RED")
                {
                    diceRoll.position = redDiceRoll.position;

                    frameRed.SetActive(true);
                    frameYellow.SetActive(false);
                    frameBlue.SetActive(false);
                }

                if (playerTurn == "YELLOW")
                {
                    diceRoll.position = yellowDiceRoll.position;

                    frameRed.SetActive(false);
                    frameYellow.SetActive(true);
                    frameBlue.SetActive(false);
                }

                if (playerTurn == "BLUE")
                {
                    diceRoll.position = blueDiceRoll.position;

                    frameRed.SetActive(false);
                    frameYellow.SetActive(false);
                    frameBlue.SetActive(true);
                }

                redPlayer1Button.interactable = false;
                redPlayer2Button.interactable = false;
                redPlayer3Button.interactable = false;
                redPlayer4Button.interactable = false;

                bluePlayer1Button.interactable = false;
                bluePlayer2Button.interactable = false;
                bluePlayer3Button.interactable = false;
                bluePlayer4Button.interactable = false;

                yellowPlayer1Button.interactable = false;
                yellowPlayer2Button.interactable = false;
                yellowPlayer3Button.interactable = false;
                yellowPlayer4Button.interactable = false;

                redPlayer1Border.SetActive(false);
                redPlayer2Border.SetActive(false);
                redPlayer3Border.SetActive(false);
                redPlayer4Border.SetActive(false);

                bluePlayer1Border.SetActive(false);
                bluePlayer2Border.SetActive(false);
                bluePlayer3Border.SetActive(false);
                bluePlayer4Border.SetActive(false);

                yellowPlayer1Border.SetActive(false);
                yellowPlayer2Border.SetActive(false);
                yellowPlayer3Border.SetActive(false);
                yellowPlayer4Border.SetActive(false);

                break;

            case 4:
                if(playerTurn == "RED")
                {
                   
                    diceRoll.position = redDiceRoll.position;

                    frameRed.SetActive(true);
                    frameGreen.SetActive(false);
                    frameYellow.SetActive(false);
                    frameBlue.SetActive(false);
                }

                if(playerTurn == "BLUE")
                {
                  
                    diceRoll.position = blueDiceRoll.position;

                    frameRed.SetActive(false);
                    frameGreen.SetActive(false);
                    frameYellow.SetActive(false);
                    frameBlue.SetActive(true);
                }

                if(playerTurn == "YELLOW")
                {
                    diceRoll.position = yellowDiceRoll.position;

                    frameRed.SetActive(false);
                    frameGreen.SetActive(false);
                    frameYellow.SetActive(true);
                    frameBlue.SetActive(false);
                }

                if(playerTurn == "GREEN")
                {
                    diceRoll.position = greenDiceroll.position;

                    frameRed.SetActive(false);
                    frameGreen.SetActive(true);
                    frameYellow.SetActive(false);
                    frameBlue.SetActive(false);
                }

                redPlayer1Button.interactable = false;
                redPlayer2Button.interactable = false;
                redPlayer3Button.interactable = false;
                redPlayer4Button.interactable = false;

                bluePlayer1Button.interactable = false;
                bluePlayer2Button.interactable = false;
                bluePlayer3Button.interactable = false;
                bluePlayer4Button.interactable = false;

                yellowPlayer1Button.interactable = false;
                yellowPlayer2Button.interactable = false;
                yellowPlayer3Button.interactable = false;
                yellowPlayer4Button.interactable = false;

                greenPlayer1Button.interactable = false;
                greenPlayer2Button.interactable = false;
                greenPlayer3Button.interactable = false;
                greenPlayer4Button.interactable = false;

                redPlayer1Border.SetActive(false);
                redPlayer2Border.SetActive(false);
                redPlayer3Border.SetActive(false);
                redPlayer4Border.SetActive(false);

                bluePlayer1Border.SetActive(false);
                bluePlayer2Border.SetActive(false);
                bluePlayer3Border.SetActive(false);
                bluePlayer4Border.SetActive(false);

                yellowPlayer1Border.SetActive(false);
                yellowPlayer2Border.SetActive(false);
                yellowPlayer3Border.SetActive(false);
                yellowPlayer4Border.SetActive(false);

                greenPlayer1Boreder.SetActive(false);
                greenPlayer2Boreder.SetActive(false);
                greenPlayer3Boreder.SetActive(false);
                greenPlayer4Boreder.SetActive(false);

                break;
        }
    }

    public void DiceRoll()
    {
        diceRollButton.interactable = false;
        selectDiceNumAnimation = randNo.Next(1, 7);

        switch (selectDiceNumAnimation)
        {
            case 1:
                dice1RollAnimation.SetActive(true);
                dice2RollAnimation.SetActive(false);
                dice3RollAnimation.SetActive(false);
                dice4RollAnimation.SetActive(false);
                dice5RollAnimation.SetActive(false);
                dice6RollAnimation.SetActive(false);
                break;

            case 2:
                dice1RollAnimation.SetActive(false);
                dice2RollAnimation.SetActive(true);
                dice3RollAnimation.SetActive(false);
                dice4RollAnimation.SetActive(false);
                dice5RollAnimation.SetActive(false);
                dice6RollAnimation.SetActive(false);
                break;

            case 3:
                dice1RollAnimation.SetActive(false);
                dice2RollAnimation.SetActive(false);
                dice3RollAnimation.SetActive(true);
                dice4RollAnimation.SetActive(false);
                dice5RollAnimation.SetActive(false);
                dice6RollAnimation.SetActive(false);
                break;

            case 4:
                dice1RollAnimation.SetActive(false);
                dice2RollAnimation.SetActive(false);
                dice3RollAnimation.SetActive(false);
                dice4RollAnimation.SetActive(true);
                dice5RollAnimation.SetActive(false);
                dice6RollAnimation.SetActive(false);
                break;

            case 5:
                dice1RollAnimation.SetActive(false);
                dice2RollAnimation.SetActive(false); 
                dice3RollAnimation.SetActive(false);
                dice4RollAnimation.SetActive(false);
                dice5RollAnimation.SetActive(true);
                dice6RollAnimation.SetActive(false);
                break;

            case 6:
                dice1RollAnimation.SetActive(false);
                dice2RollAnimation.SetActive(false);
                dice3RollAnimation.SetActive(false);
                dice4RollAnimation.SetActive(false);
                dice5RollAnimation.SetActive(false);
                dice6RollAnimation.SetActive(true);
                break;
        }

        StartCoroutine("PlayersNotInitialized");
    }

   IEnumerator PlayersNotInitialized()
    {
        yield return new WaitForSeconds(1f);

        switch (playerTurn)
        {
            case "RED":
                if (!redPlayer1Border.activeInHierarchy && !redPlayer2Border.activeInHierarchy && !redPlayer3Border.activeInHierarchy && !redPlayer4Border.activeInHierarchy)
                {
                    redPlayer1Button.interactable = false;
                    redPlayer2Button.interactable = false;
                    redPlayer3Button.interactable = false;
                    redPlayer4Button.interactable = false; 

                    switch (numberOfPlayers)
                    {
                        case 2:
                        playerTurn = "GREEN";
                        IntializeDice();
                         break;

                        case 3:
                            playerTurn = "BLUE";
                            IntializeDice();
                            break;

                        case 4:
                            playerTurn = "BLUE";
                            IntializeDice();
                            break;
                    } 
                }
                break;

            case "GREEN":
                if (!greenPlayer1Boreder.activeInHierarchy && !greenPlayer2Boreder.activeInHierarchy && !greenPlayer3Boreder.activeInHierarchy && !greenPlayer4Boreder.activeInHierarchy)
                {
                    greenPlayer1Button.interactable = false;
                    greenPlayer2Button.interactable = false;
                    greenPlayer3Button.interactable = false;
                    greenPlayer4Button.interactable = false;

                    switch (numberOfPlayers)
                    {
                        case 2:
                            playerTurn = "RED";
                            IntializeDice();
                            break;

                        case 3:
                            //Green player not available
                            break;

                        case 4:
                            playerTurn = "YELLOW";
                            IntializeDice();
                            break;
                    }
                }

                break;

            case "BLUE":
                if(!bluePlayer1Border.activeInHierarchy && !bluePlayer2Border.activeInHierarchy && !bluePlayer3Border.activeInHierarchy && !bluePlayer4Border.activeInHierarchy)
                {
                    bluePlayer1Button.interactable = false;
                    bluePlayer2Button.interactable = false;
                    bluePlayer3Button.interactable = false;
                    bluePlayer4Button.interactable = false;

                    switch (numberOfPlayers)
                    {
                        case 2:
                            //Blue player not available
                            break;
                        
                        case 3:
                            playerTurn = "YELLOW";
                            IntializeDice();
                            break;

                        case 4:
                            playerTurn = "GREEN";
                            IntializeDice();
                            break;
                    }
                }
               
                break;

            case "YELLOW":
                if(!yellowPlayer1Border.activeInHierarchy && !yellowPlayer2Border.activeInHierarchy && !yellowPlayer3Border.activeInHierarchy && !yellowPlayer4Border.activeInHierarchy)
                {
                    yellowPlayer1Button.interactable = false;
                    yellowPlayer2Button.interactable = false;
                    yellowPlayer3Button.interactable = false;
                    yellowPlayer4Button.interactable = false;

                    switch (numberOfPlayers)
                    {
                        case 2:
                            //yellow player not available
                            break;

                        case 3:
                            playerTurn = "RED";
                            IntializeDice();
                            break;

                        case 4:
                            playerTurn = "RED";
                            IntializeDice();
                            break;
                    }
                }

                break;
        }
    }


// Start is called before the first frame update
    void Start()
    {
        QualitySettings.vSyncCount = 1; 
        Application.targetFrameRate = 30;   //Set frame rate and vsync to maintain quality of game(res)

        randNo = new System.Random();

        dice1RollAnimation.SetActive(false);
        dice2RollAnimation.SetActive(false);
        dice3RollAnimation.SetActive(false);
        dice4RollAnimation.SetActive(false);
        dice5RollAnimation.SetActive(false);
        dice6RollAnimation.SetActive(false);

        //Player intital positions
        redPlayer1Pos = redPlayer1.transform.position;
        redPlayer2Pos = redPlayer1.transform.position;
        redPlayer3Pos = redPlayer1.transform.position;
        redPlayer4Pos = redPlayer1.transform.position;

        greenPlayer1Pos = greenPlayer1.transform.position;
        greenPlayer2Pos = greenPlayer1.transform.position;
        greenPlayer3Pos = greenPlayer1.transform.position;
        greenPlayer4Pos = greenPlayer1.transform.position;

        yellowPlayer1Pos = yellowPlayer1.transform.position;
        yellowPlayer2Pos = yellowPlayer1.transform.position;
        yellowPlayer3Pos = yellowPlayer1.transform.position;
        yellowPlayer4Pos = yellowPlayer1.transform.position;

        bluePlayer1Pos = bluePlayer1.transform.position;
        bluePlayer2Pos = bluePlayer1.transform.position;
        bluePlayer3Pos = bluePlayer1.transform.position;
        bluePlayer4Pos = bluePlayer1.transform.position;

        //Deactivating player round borders
        redPlayer1Border.SetActive(false);
        redPlayer2Border.SetActive(false);
        redPlayer3Border.SetActive(false);
        redPlayer4Border.SetActive(false);

        greenPlayer1Boreder.SetActive(false);
        greenPlayer2Boreder.SetActive(false);
        greenPlayer3Boreder.SetActive(false);
        greenPlayer4Boreder.SetActive(false);

        yellowPlayer1Border.SetActive(false);
        yellowPlayer2Border.SetActive(false);
        yellowPlayer3Border.SetActive(false);
        yellowPlayer4Border.SetActive(false);

        bluePlayer1Border.SetActive(false);
        bluePlayer2Border.SetActive(false);
        bluePlayer3Border.SetActive(false);
        bluePlayer4Border.SetActive(false);

        redScreen.SetActive(false);
        blueScreen.SetActive(false);
        yellowScreen.SetActive(false);
        greenScreen.SetActive(false);

        switch (numberOfPlayers)
        {
            case 2:
                playerTurn = "RED";

                frameRed.SetActive(true);
                frameGreen.SetActive(false);
               

                bluePlayer1.SetActive(false);
                bluePlayer2.SetActive(false);
                bluePlayer3.SetActive(false);
                bluePlayer4.SetActive(false);

                yellowPlayer1.SetActive(false);
                yellowPlayer2.SetActive(false);
                yellowPlayer3.SetActive(false);
                yellowPlayer4.SetActive(false);

                break;

            case 3:
                playerTurn = "RED";

                frameYellow.SetActive(false);
                frameRed.SetActive(true);
                frameBlue.SetActive(false);

                diceRoll.position = redDiceRoll.position;

                greenPlayer1.SetActive(false);
                greenPlayer2.SetActive(false);
                greenPlayer3.SetActive(false);
                greenPlayer4.SetActive(false);

                break;

            case 4:
                playerTurn = "RED";

                diceRoll.position = redDiceRoll.position;

                frameRed.SetActive(true);
                frameGreen.SetActive(false);
                frameBlue.SetActive(false);
                frameYellow.SetActive(false);

                break;

        }

    }

  

    // Update is called once per frame
    void Update()
    {
        
    }
}
