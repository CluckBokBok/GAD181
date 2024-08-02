using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Game 3 Script - the recipes that the player needs to make

namespace SAE.GAD181.Game3
{

    public class SetRecipes : MonoBehaviour
    {

        #region Variables

        [SerializeField] private int recipeIndex; // number of recipes
        [SerializeField] private int recipeDifficulty; // recipe difficulty easy, medium, hard 

        public int currentRecipeBread = 0; // current recipe bread
        public int currentRecipeCarrot = 0; // current recipe carrot
        public int currentRecipeTomato = 0; // current recipe tomato
        public int currentRecipePotato = 0; // current recipe potato

        #endregion

        void Start()
        {
            ChangeRecipe();
        }


        void Update()
        {
            // remove this later
            #region Change Recipe Manually
            if (Input.GetKeyDown(KeyCode.Alpha1)) // number 1
            {
                ChangeRecipe();
            }

            #endregion
        }

        #region Recipe Change
        public void ChangeRecipe() // changes the current recipe - this functions requires consistent changing depending on the amount of recipes
        {
            recipeDifficulty = Random.Range(1, 11);

            if (recipeDifficulty >= 1 && recipeDifficulty <= 6) // easy recipes - 60% chance
            {
                Debug.Log("easy recipe");
                recipeIndex = Random.Range(1, 2); // second number should be amount of recipes + 1 for overload

                if (recipeIndex == 1)
                {
                    NicksRecipe();
                }

            }

            if (recipeDifficulty >= 7 && recipeDifficulty <= 9) // medium recipes
            {
                Debug.Log("medium recipe");
                recipeIndex = Random.Range(1, 2); // second number should be amount of recipes + 1 for overload

                if (recipeIndex == 1) 
                {
                    TestRecipe();
                }

            }

            if (recipeDifficulty == 10) // hard recipes
            {
                Debug.Log("hard recipe");

            }

        }
        #endregion

        #region Set Recipes

        private void NicksRecipe() // remove this when actual recipes are made
        {
            currentRecipeBread = 1;
            currentRecipeCarrot = 3;
            currentRecipeTomato = 1;
            currentRecipePotato = 5;
        }

        private void TestRecipe() // remove this when actual recipes are made
        {
            currentRecipeBread = 10;
            currentRecipeCarrot = 5;
            currentRecipeTomato = 1;
            currentRecipePotato = 3;
        }

        #endregion


    }
}


