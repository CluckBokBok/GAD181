using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Game 3 Script - the recipes that the player needs to make

namespace SAE.GAD181.Game3
{

    public class CheckRecipeSubmission : MonoBehaviour
    {
        public PlayerIngredients playerIngredientsRef;
        public SetRecipes recipeIngredientsRef;

        public GameObject lilTrolling; // remove this later (:

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
            if (playerIngredientsRef == null)
            {
                Debug.Log("PlayerIngredients missing");
            }

            if (recipeIngredientsRef == null)
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
            Debug.Log("xdd"); // xdd

            if (playerIngredientsRef.currentPlayerBread == recipeIngredientsRef.currentRecipeBread && playerIngredientsRef.currentPlayerCarrot == recipeIngredientsRef.currentRecipeCarrot && playerIngredientsRef.currentPlayerTomato == recipeIngredientsRef.currentRecipeTomato && playerIngredientsRef.currentPlayerPotato == recipeIngredientsRef.currentRecipePotato)
            {
                Debug.Log("Correct!");
                lilTrolling.SetActive(false);
            }

            else
            {
                Debug.Log("Wrong!");
                lilTrolling.SetActive(true); // remove this later (:
            }

        }

    }
}
