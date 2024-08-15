using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;


// Game 3 Script - the recipes that the player needs to make

namespace SAE.GAD181.Game3
{

    public class CheckRecipeSubmission : MonoBehaviour
    {
        public PlayerIngredients pIR; // player ingredient reference
        public RecipeMasherGameManager gameManagerReference;
        public SetRecipes rIR; // recipe ingredient referece
        public int playerLives;
        public int playerPoints;
        public Countdown countDown;


        public bool lifeOneLosable = true;
        public bool lifeTwoLosable = true;
        public bool lifeThreeLosable = true;
        [SerializeField] private TextMeshProUGUI playerPointsText;
        

        public GameObject wajajaCat; // cat laughing at you
        public GameObject thumbsUpCat; // cat giving you a thumbs up

        void Start()
        {
            ObjectReferenceCheck();
            playerLives = 3;
            playerPoints = 0;
        }


        void Update()
        {
            
        }

        public void ObjectReferenceCheck() // objects that get checked for null 
        {
            #region Objects To Check For Null
            if (pIR == null)
            {
                Debug.Log("PlayerIngredients missing");
            }

            if (rIR == null)
            {
                Debug.Log("RecipeIngredients missing");
            }

            #endregion
            else
            {
                Debug.Log("Object Reference Check Complete");
            }

        }

        public void RecipeSubmissionCheck()
        {
            if (pIR.currentPlayerBread == rIR.currentRecipeBread && pIR.currentPlayerCarrot == rIR.currentRecipeCarrot && pIR.currentPlayerTomato == rIR.currentRecipeTomato && pIR.currentPlayerPotato == rIR.currentRecipePotato && pIR.currentPlayerBroccoli == rIR.currentRecipeBroccoli && pIR.currentPlayerCheese == rIR.currentRecipeCheese && pIR.currentPlayerSausage == rIR.currentRecipeSausage && pIR.currentPlayerMushroom == rIR.currentRecipeMushroom && pIR.currentPlayerTBone == rIR.currentRecipeTBone && pIR.currentPlayerBacon == rIR.currentRecipeBacon && pIR.currentPlayerEgg == rIR.currentRecipeEgg && pIR.currentPlayerFish == rIR.currentRecipeFish && pIR.currentPlayerFlour == rIR.currentRecipeFlour && pIR.currentPlayerSugar == rIR.currentRecipeSugar && pIR.currentPlayerPasta == rIR.currentRecipePasta && pIR.currentPlayerMilk == rIR.currentRecipeMilk)
            {
               
                Debug.Log("Correct!");

                wajajaCat.SetActive(false); // turn off wajaja cat - should realistically turn off on itself
                thumbsUpCat.SetActive(true);

                playerPoints++;
                countDown.AddTime(10);
                playerPointsText.text = "" + playerPoints; 
             
                pIR.ResetPlayerIngredients();
                rIR.ResetRecipeIngredients();

                rIR.ChangeRecipe();

                StartCoroutine(DeactivateCatsAfterDelay()); //turns off cat image after 2 seconds



                //recipeTextDisplayerReference.RecipeReset();
            }

            else
            {
                Debug.Log("Wrong!");
                wajajaCat.SetActive(true); // cat laughing at you
                thumbsUpCat.SetActive(false);
                pIR.ResetPlayerIngredients();
                playerLives --; 

                if (playerLives >= 3)
                {
                    gameManagerReference.liveThree.SetActive(true);
                }
                if (playerLives == 2)
                {
                    gameManagerReference.liveThree.SetActive(false);
                    gameManagerReference.liveTwo.SetActive(true);
                }
                if (playerLives == 1)
                {
                    gameManagerReference.liveTwo.SetActive(false);
                    gameManagerReference.liveOne.SetActive(true);
                }
                if (playerLives <= 0)
                {
                    gameManagerReference.liveOne.SetActive(false);
                }

                StartCoroutine(DeactivateCatsAfterDelay()); //turns off cat image after 2 seconds

                //recipeTextDisplayerReference.RecipeReset();
            }

        }

        private IEnumerator DeactivateCatsAfterDelay()
        {
            yield return new WaitForSeconds(2f);
            wajajaCat.SetActive(false);
            thumbsUpCat.SetActive(false);
        }
    }
}
