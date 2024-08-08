using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Game 3 Script - the recipes that the player needs to make

namespace SAE.GAD181.Game3
{

    public class CheckRecipeSubmission : MonoBehaviour
    {
        public PlayerIngredients pIR; // player ingredient reference
        public SetRecipes rIR; // recipe ingredient referece

        public GameObject wajajaCat; // cat laughing at you

        void Start()
        {
            ObjectReferenceCheck();
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
            // Debug.Log("This is: " + name); // debug object name
            // Debug.Log("xdd"); // xdd

            if (pIR.currentPlayerBread == rIR.currentRecipeBread && pIR.currentPlayerCarrot == rIR.currentRecipeCarrot && pIR.currentPlayerTomato == rIR.currentRecipeTomato && pIR.currentPlayerPotato == rIR.currentRecipePotato && pIR.currentPlayerBrocolli == rIR.currentRecipeBrocolli && pIR.currentPlayerCheese == rIR.currentRecipeCheese && pIR.currentPlayerSausage == rIR.currentRecipeSausage && pIR.currentPlayerMushroom == rIR.currentRecipeMushroom && pIR.currentPlayerTBone == rIR.currentRecipeTBone && pIR.currentPlayerBacon == rIR.currentRecipeBacon && pIR.currentPlayerEgg == rIR.currentRecipeEgg && pIR.currentPlayerFish == rIR.currentRecipeFish && pIR.currentPlayerFlour == rIR.currentRecipeFlour && pIR.currentPlayerSugar == rIR.currentRecipeSugar && pIR.currentPlayerPasta == rIR.currentRecipePasta && pIR.currentPlayerMilk == rIR.currentRecipeMilk)
            {
               
                Debug.Log("Correct!");

                wajajaCat.SetActive(false); // turn off wajaja cat - should realistically turn off on itself

                pIR.ResetPlayerIngredients();
                rIR.ChangeRecipe();
            }

            else
            {
                Debug.Log("Wrong!");
                wajajaCat.SetActive(true); // cat laughing at you
                
            }

        }

    }
}
