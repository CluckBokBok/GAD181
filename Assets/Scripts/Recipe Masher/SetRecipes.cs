using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Game 3 Script - the recipes that the player needs to make

namespace SAE.GAD181.Game3
{

    public class SetRecipes : MonoBehaviour
    {

        #region Variables

        public int currentRecipeBread = 0; // current recipe bread
        public int currentRecipeCarrot = 0; // current recipe carrot
        public int currentRecipeTomato = 0; // current recipe tomato
        public int currentRecipePotato = 0; // current recipe potato

        #endregion

        void Start()
        {
            NicksRecipe();
        }


        void Update()
        {

        }

        #region Set Recipes

        public void NicksRecipe() // nicks potato recipe
        {
            currentRecipeBread = 1;
            currentRecipeCarrot = 3;
            currentRecipeTomato = 1;
            currentRecipePotato = 5;
        }

        public void TestRecipe() // can delete this
        {

        }

        #endregion


    }
}


