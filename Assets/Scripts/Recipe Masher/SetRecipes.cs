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

        public int currentRecipeBread = 0; // current recipe - bread
        public int currentRecipeCarrot = 0; // current recipe - carrot
        public int currentRecipeTomato = 0; // current recipe - tomato
        public int currentRecipePotato = 0; // current recipe - potato
        public int currentRecipeBroccoli = 0; // current recipe - Broccoli
        public int currentRecipeCheese = 0; // current recipe - cheese
        public int currentRecipeSausage = 0; // current recipe - sausage
        public int currentRecipeMushroom = 0; // current recipe - mushroom
        public int currentRecipeTBone = 0; // current recipe - t bone
        public int currentRecipeBacon = 0; // current recipe - bacon
        public int currentRecipeEgg = 0; // current recipe - egg
        public int currentRecipeFish = 0; // current recipe - fish
        public int currentRecipeFlour = 0; // current recipe - flour
        public int currentRecipeSugar = 0; // current recipe - sugar
        public int currentRecipePasta = 0; // current recipe - pasta
        public int currentRecipeMilk = 0; // current recipe - milk

        #endregion

        void Start()
        {
            ChangeRecipe();
        }


        void Update()
        {

        }

        // this is the selection of recipes that can be picked randomly
        #region Recipe Change
        public void ChangeRecipe() // changes the current recipe - this functions requires consistent changing depending on the amount of recipes
        {
            recipeDifficulty = Random.Range(1, 11);

            #region Easy Recipes
            if (recipeDifficulty >= 1 && recipeDifficulty <= 4) // easy recipes - 60% chance
            {
                //Debug.Log("easy recipe");
                recipeIndex = Random.Range(1, 4); // second number should be amount of recipes + 1 for overload

                if (recipeIndex == 1)
                {
                    CheeseSandwich();
                }

                if (recipeIndex == 2)
                {
                    BaconNEggsSandwich();
                }

                if (recipeIndex == 3)
                {
                    MacNCheese(); 
                }

            }
            #endregion

            #region Medium Recipes
            if (recipeDifficulty >= 5 && recipeDifficulty <= 8) // medium recipes
            {
                //Debug.Log("medium recipe");
                recipeIndex = Random.Range(1, 4); // second number should be amount of recipes + 1 for overload

                if (recipeIndex == 1) 
                {
                    SausageSizzle();
                }

                if (recipeIndex == 2)
                {
                    Pancakes();
                }

                if (recipeIndex == 3)
                {
                    FishDinner();
                }

            }
            #endregion

            #region Hard Recipes
            if (recipeDifficulty >= 9 && recipeDifficulty <= 10) // hard recipes
            {
                //Debug.Log("hard recipe");
                recipeIndex = Random.Range(1, 4); // second number should be amount of recipes + 1 for overload

                if (recipeIndex == 1)
                {
                    BigBreakfast();
                }

                if (recipeIndex == 1)
                {
                    SteakDinner();
                }

                if (recipeIndex == 1)
                {
                    Salad();
                }

            }
            #endregion

        }
        #endregion

        // add any recipes that will be selected here
        #region Set Recipes

        private void CheeseSandwich() // easy 1
        {
            currentRecipeBread = 1;
            currentRecipeCheese = 2;
        }

        private void BaconNEggsSandwich() // easy 2
        {
            currentRecipeBacon = 2;
            currentRecipeEgg = 1;
            currentRecipeBread = 1;
        }

        private void MacNCheese() // easy 3
        {
            currentRecipePasta = 1;
            currentRecipeCheese = 2;
            currentRecipeMilk = 1;
        }

        private void SausageSizzle() // medium 1
        {
            currentRecipeBread = 1;
            currentRecipeSausage = 1;
            currentRecipeCheese = 2;
        }

        private void Pancakes() // medium 2
        {
            currentRecipeFlour = 2;
            currentRecipeSugar = 1;
            currentRecipeMilk = 1;
            currentRecipeEgg = 2;

        }

        private void FishDinner() // medium 3
        {
            currentRecipeFish = 1;
            currentRecipeMushroom = 3;
            currentRecipeBroccoli = 2;
        }

        private void BigBreakfast() // hard 1
        {
            currentRecipeSausage = 2;
            currentRecipeEgg = 2;
            currentRecipeTBone = 1;
            currentRecipeBacon = 2;
            currentRecipeTomato = 2;
        }

        private void SteakDinner() // hard 2
        {
            currentRecipeTBone = 1;
            currentRecipeBroccoli = 2;
            currentRecipeMushroom = 3;
            currentRecipeEgg = 1;
        }

        private void Salad() // hard 3
        {
            currentRecipeTomato = 3;
            currentRecipeCarrot = 2;
            currentRecipeBroccoli = 1;
            currentRecipePotato = 2;
        }


        #endregion

        public void ResetRecipeIngredients() // resets recipe ingredients
        {

            currentRecipeBread = 0; 
            currentRecipeCarrot = 0; 
            currentRecipeTomato = 0; 
            currentRecipePotato = 0; 
            currentRecipeBroccoli = 0; 
            currentRecipeCheese = 0; 
            currentRecipeSausage = 0; 
            currentRecipeMushroom = 0; 
            currentRecipeTBone = 0; 
            currentRecipeBacon = 0; 
            currentRecipeEgg = 0; 
            currentRecipeFish = 0; 
            currentRecipeFlour = 0; 
            currentRecipeSugar = 0;
            currentRecipePasta = 0;
            currentRecipeMilk = 0;
           
        }

    }
}


