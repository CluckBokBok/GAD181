using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Game 3 Script - the ingredients the player will have

namespace SAE.GAD181.Game3
{

    public class PlayerIngredients : MonoBehaviour
    {

        #region Variables

        public int currentPlayerBread = 0; // player - bread
        public int currentPlayerCarrot = 0; // player - carrot
        public int currentPlayerTomato = 0; // player - tomato
        public int currentPlayerPotato = 0; // player - potato
        public int currentPlayerBroccoli = 0; // player - brocolli
        public int currentPlayerCheese = 0; // player - cheese
        public int currentPlayerSausage = 0; // player - sausage
        public int currentPlayerMushroom = 0; // player - mushroom
        public int currentPlayerTBone = 0; // player - t bone
        public int currentPlayerBacon = 0; // player - bacon
        public int currentPlayerEgg = 0; // player - egg
        public int currentPlayerFish = 0; // player - fish
        public int currentPlayerFlour = 0; // player - flour
        public int currentPlayerSugar = 0; // player - sugar
        public int currentPlayerPasta = 0; // player - pasta
        public int currentPlayerMilk = 0; // player - milk

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
            currentPlayerBroccoli = 0; 
            currentPlayerCheese = 0; 
            currentPlayerSausage = 0;
            currentPlayerMushroom = 0; 
            currentPlayerTBone = 0;
            currentPlayerBacon = 0; 
            currentPlayerEgg = 0; 
            currentPlayerFish = 0; 
            currentPlayerFlour = 0; 
            currentPlayerSugar = 0; 
            currentPlayerPasta = 0; 
            currentPlayerMilk = 0; 
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

        public void AddPlayerBrocolli(int amount)
        {
            currentPlayerBroccoli += amount;
        }

        public void AddPlayerCheese(int amount)
        {
            currentPlayerCheese += amount;
        }

        public void AddPlayerSausage(int amount)
        {
            currentPlayerSausage += amount;
        }

        public void AddPlayerMushroom(int amount)
        {
            currentPlayerMushroom += amount;
        }

        public void AddPlayerTBone(int amount)
        {
            currentPlayerTBone += amount;
        }

        public void AddPlayerBacon(int amount)
        {
            currentPlayerBacon += amount;
        }

        public void AddPlayerEgg(int amount)
        {
            currentPlayerEgg += amount;
        }

        public void AddPlayerFish(int amount)
        {
            currentPlayerFish += amount;
        }

        public void AddPlayerFlour(int amount)
        {
            currentPlayerFlour += amount;
        }

        public void AddPlayerSugar(int amount)
        {
            currentPlayerSugar += amount;
        }

        public void AddPlayerPasta(int amount)
        {
            currentPlayerPasta += amount;
        }

        public void AddPlayerMilk(int amount)
        {
            currentPlayerMilk += amount;
        }



        #endregion


    }
}

