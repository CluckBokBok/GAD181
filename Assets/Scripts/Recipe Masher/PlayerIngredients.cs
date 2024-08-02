using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Game 3 Script - the ingredients the player will have

namespace SAE.GAD181.Game3
{

    public class PlayerIngredients : MonoBehaviour
    {

        #region Variables

        public int currentPlayerBread = 0; // player bread
        public int currentPlayerCarrot = 0; // player carrot
        public int currentPlayerTomato = 0; // player tomato
        public int currentPlayerPotato = 0; // player potato

        #endregion

        void Start()
        {
           
        }

        void Update()
        {

        }

        // add all ingredients here and make them = 0
        public void ResetPlayerIngredients() // resets player ingredient count
        {
            currentPlayerBread = 0;
            currentPlayerCarrot = 0;
            currentPlayerTomato = 0;
            currentPlayerPotato = 0;
        }

        // changes the value of the current player ingredients
        #region Change Player Ingredient Values

        public void AddPlayerBread(int amount)
        {
            currentPlayerBread += amount;

        }

        public void AddPlayerCarrot(int amount)
        {
            currentPlayerCarrot += amount;
        }

        public void AddPlayerTomato(int amount)
        {
            currentPlayerTomato += amount;
        }

        public void AddPlayerPotato(int amount)
        {
            currentPlayerPotato += amount;
        }

        #endregion


    }
}

