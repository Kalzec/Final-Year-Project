using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour {

    //For selecting starting coins
    public InputField input;
    public GameObject coinSelectItems;

    //Variable to hold users coins
    public int coins;

    //Text to hold the coin count
    public Text coinCount;

    //Game Object to  hold the buttons in
    public GameObject buttons;

    //Variables to hold loot box item chances
    int uncommonChance;
    int rareChance;
    int legendaryChance;

    //bool to check whether a box has been picked or not
    bool boxPicked = false;

    //ints to hold loot item choices
    int lootOneChoice;
    int lootTwoChoice;
    int lootThreeChoice;
    int lootFourChoice;

    //bools to pick each loot item
    bool lootOnePicked = false;
    bool lootTwoPicked = false;
    bool lootThreePicked = false;
    bool lootFourPicked = false;

    //Game Objects to hold Loot
    public GameObject lootOne;
    public Text lootOneText;
    public GameObject lootTwo;
    public Text lootTwoText;
    public GameObject lootThree;
    public Text lootThreeText;
    public GameObject lootFour;
    public Text lootFourText;

    //GameObject to hold collect Loot Button
    public GameObject collectLoot;

    // Use this for initialization
    void Start () {
        
        coinCount.text = "Coins: " + coins.ToString();
    }

    public void setCoins()
    {
        coins = int.Parse(input.text); //for integer;
        coinCount.text = "Coins: " + coins.ToString();
        buttons.SetActive(true); //Remove buttons from screen
        coinSelectItems.SetActive(false); //Remove coin select from screen
    }

    //--------------------
    //Choosing Box methods
    //--------------------

    //Method for choosing Bronze Box
    public void ChooseBronze()
    {
        if (coins >= 300)
        {
            coins -= 300; //minus coins
            coinCount.text = "Coins: " + coins.ToString(); //update UI
            buttons.SetActive(false); //Remove buttons from screen
            uncommonChance = 4;
            rareChance = 100;
            legendaryChance = 1000;
            boxPicked = true;
        }
    }

    //Method for choosing Silver Box
    public void ChooseSilver()
    {
        if (coins >= 800)
        {
            coins -= 800; //minus coins
            coinCount.text = "Coins: " + coins.ToString(); //update UI
            buttons.SetActive(false); //Remove buttons from screen
            uncommonChance = 3;
            rareChance = 20;
            legendaryChance = 200;
            boxPicked = true;
        }
    }

    //Method for choosing Gold Box
    public void ChooseGold()
    {
        if (coins >= 1500)
        {
            coins -= 1500; //minus coins
            coinCount.text = "Coins: " + coins.ToString(); //update UI
            buttons.SetActive(false); //Remove buttons from screen
            uncommonChance = 2;
            rareChance = 14;
            legendaryChance = 100;
            boxPicked = true;
        }
    }

    //Method for choosing Diamond Box
    public void ChooseDiamond()
    {
        if (coins >= 2300)
        {
            coins -= 2300; //minus coins
            coinCount.text = "Coins: " + coins.ToString(); //update UI
            buttons.SetActive(false); //Remove buttons from screen
            uncommonChance = 2;
            rareChance = 10;
            legendaryChance = 33;
            boxPicked = true;
        }
    }

    void LootOneController()
    {
        if (lootOnePicked == false)
        {
            //check if item is legendary
            lootOneChoice = Random.Range(0, legendaryChance);
            Debug.Log("Loot 1 Legendary" + lootOneChoice);

            //if legendary has been chosen
            if (lootOneChoice <= 0)
            {
                lootOneText.text = "legendary";
                //draw the UI box
                lootOne.SetActive(true);
                lootOnePicked = true;
                LootTwoController();

            }
        }

        if (lootOnePicked == false)
        {
            //check if item is rare
            lootOneChoice = Random.Range(0, rareChance);
            Debug.Log("Loot 1 Rare" + lootOneChoice);

            //if rare has been chosen
            if (lootOneChoice <= 0)
            {
                lootOneText.text = "Rare";
                //draw the UI box
                lootOne.SetActive(true);
                lootOnePicked = true;
                LootTwoController();
            }
        }

        if (lootOnePicked == false)
        {
            //check if item is uncoom
            lootOneChoice = Random.Range(0, uncommonChance);
            Debug.Log("Loot 1 UnCommon" + lootOneChoice);

            //if rare has been chosen
            if (lootOneChoice <= 0)
            {
                lootOneText.text = "UnCommon";
                //draw the UI box
                lootOne.SetActive(true);
                lootOnePicked = true;
                LootTwoController();
            }
            //if not, it is common
            else
            {
                lootOneText.text = "Common";
                //draw the UI box
                lootOne.SetActive(true);
                lootOnePicked = true;
                LootTwoController();
            }
        }
    }

    void LootTwoController()
    {
        if (lootTwoPicked == false)
        {
            //check if item is legendary
            lootTwoChoice = Random.Range(0, legendaryChance);
            Debug.Log("Loot 2 Legendary" + lootTwoChoice);

            //if legendary has been chosen
            if (lootTwoChoice <= 0)
            {
                lootTwoText.text = "legendary";
                //draw the UI box
                lootTwo.SetActive(true);
                lootTwoPicked = true;
                LootThreeController();

            }
        }

        if (lootTwoPicked == false)
        {
            //check if item is rare
            lootTwoChoice = Random.Range(0, rareChance);
            Debug.Log("Loot 2 Rare" + lootTwoChoice);

            //if rare has been chosen
            if (lootTwoChoice <= 0)
            {
                lootTwoText.text = "Rare";
                //draw the UI box
                lootTwo.SetActive(true);
                lootTwoPicked = true;
                LootThreeController();
            }
        }

        if (lootTwoPicked == false)
        {
            //check if item is uncoom
            lootTwoChoice = Random.Range(0, uncommonChance);
            Debug.Log("Loot 2 unCommon" + lootTwoChoice);

            //if rare has been chosen
            if (lootTwoChoice <= 0)
            {
                lootTwoText.text = "UnCommon";
                //draw the UI box
                lootTwo.SetActive(true);
                lootTwoPicked = true;
                LootThreeController();
            }
            //if not, it is common
            else
            {
                lootTwoText.text = "Common";
                //draw the UI box
                lootTwo.SetActive(true);
                lootTwoPicked = true;
                LootThreeController();
            }
        }
    }

    void LootThreeController()
    {
        if (lootThreePicked == false)
        {
            //check if item is legendary
            lootThreeChoice = Random.Range(0, legendaryChance);
            Debug.Log("Loot 3 Legendary" + lootThreeChoice);

            //if legendary has been chosen
            if (lootThreeChoice <= 0)
            {
                lootThreeText.text = "legendary";
                //draw the UI box
                lootThree.SetActive(true);
                lootThreePicked = true;
                LootFourController();
            }
        }

        if (lootThreePicked == false)
        {
            //check if item is rare
            lootThreeChoice = Random.Range(0, rareChance);
            Debug.Log("Loot 3 Rare" + lootThreeChoice);

            //if rare has been chosen
            if (lootThreeChoice <= 0)
            {
                lootThreeText.text = "Rare";
                //draw the UI box
                lootThree.SetActive(true);
                lootThreePicked = true;
                LootFourController();
            }
        }

        if (lootThreePicked == false)
        {
            //check if item is uncoom
            lootThreeChoice = Random.Range(0, uncommonChance);
            Debug.Log("Loot 3 UnCommon" + lootThreeChoice);

            //if rare has been chosen
            if (lootThreeChoice <= 0)
            {
                lootThreeText.text = "UnCommon";
                //draw the UI box
                lootThree.SetActive(true);
                lootThreePicked = true;
                LootFourController();
            }
            //if not, it is common
            else
            {
                lootThreeText.text = "Common";
                //draw the UI box
                lootThree.SetActive(true);
                lootThreePicked = true;
                LootFourController();
            }
        }
    }

    void LootFourController()
    {
        if (lootFourPicked == false)
        {
            //check if item is legendary
            lootFourChoice = Random.Range(0, legendaryChance);
            Debug.Log("Loot 4 Legendary" + lootFourChoice);

            //if legendary has been chosen
            if (lootFourChoice <= 0)
            {             
                lootFourText.text = "legendary";
                //draw the UI box
                lootFour.SetActive(true);
                lootFourPicked = true;
                //set the collect loot button active
                collectLoot.SetActive(true);

            }
        }

        if (lootFourPicked == false)
        {
            //check if item is rare
            lootFourChoice = Random.Range(0, rareChance);
            Debug.Log("Loot 4 Rare" + lootFourChoice);

            //if rare has been chosen
            if (lootFourChoice <= 0)
            {
                lootFourText.text = "Rare";
                //draw the UI box
                lootFour.SetActive(true);
                lootFourPicked = true;
                //set the collect loot button active
                collectLoot.SetActive(true);
            }
        }

        if (lootFourPicked == false)
        {
            //check if item is uncoom
            lootFourChoice = Random.Range(0, uncommonChance);
            Debug.Log("Loot 4 UnCommon" + lootFourChoice);

            //if rare has been chosen
            if (lootFourChoice <= 0)
            {
                lootFourText.text = "UnCommon";
                //draw the UI box
                lootFour.SetActive(true);
                lootFourPicked = true;
                //set the collect loot button active
                collectLoot.SetActive(true);
            }
            //if not, it is common
            else
            {
                lootFourText.text = "Common";
                //draw the UI box
                lootFour.SetActive(true);
                lootFourPicked = true;
                //set the collect loot button active
                collectLoot.SetActive(true);
            }
        }
    }

    public void CollectLoot()
    {
            //disable loot item UI
            lootOne.SetActive(false);
            lootTwo.SetActive(false);
            lootThree.SetActive(false);
            lootFour.SetActive(false);

            //reset variables
            boxPicked = false;
            lootOnePicked = false;
            lootTwoPicked = false;
            lootThreePicked = false;
            lootFourPicked = false;

        //if there are enough coins to pick a new box, pick again, otherwise bring up coin select again
        if (coins >= 300)
        {
            //show buttons for picking again
            buttons.SetActive(true); //Remove buttons from screen
        }
        else
        {
            coinSelectItems.SetActive(true);
        }

        //remove collect Loot Button
        collectLoot.SetActive(false);
       

    }

    // Update is called once per frame
    void Update () {

        //if box is picked, call the first Loot Item Method
        if (boxPicked == true)
        {
            if (lootOnePicked == false)
            {
                LootOneController();
            }
        }

        //press Escape to end simulation
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }
}
