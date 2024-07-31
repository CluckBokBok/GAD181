using SAE.GAD181.Game3;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RecipeTextDisplayer : MonoBehaviour
{

    public SetRecipes setRecipeReference;
    public PlayerIngredients playerIngredientsReference;

    [SerializeField] private string recipeNeededBread;
    [SerializeField] private string recipeNeededPotato;
    [SerializeField] private string recipeNeededTomato;
    [SerializeField] private string recipeNeededCarrot;

    [SerializeField] private TextMeshProUGUI breadText;
    [SerializeField] private TextMeshProUGUI potatoText;
    [SerializeField] private TextMeshProUGUI tomatoText;
    [SerializeField] private TextMeshProUGUI carrotText;

    [SerializeField] private string playersCurrentBreadCount;
    [SerializeField] private string playersCurrentPotatoCount;
    [SerializeField] private string playersCurrentTomatoCount;
    [SerializeField] private string playersCurrentCarrotCount;

    [SerializeField] private TextMeshProUGUI playerBreadText;
    [SerializeField] private TextMeshProUGUI playerPotatoText;
    [SerializeField] private TextMeshProUGUI playerTomatoText;
    [SerializeField] private TextMeshProUGUI playerCarrotText;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        recipeNeededBread = setRecipeReference.currentRecipeBread.ToString();
        recipeNeededPotato = setRecipeReference.currentRecipePotato.ToString();
        recipeNeededTomato = setRecipeReference.currentRecipeTomato.ToString();
        recipeNeededCarrot = setRecipeReference.currentRecipeCarrot.ToString();

        breadText.text = "Bread needed: " + recipeNeededBread;
        potatoText.text = "Potato needed: " + recipeNeededPotato;
        tomatoText.text = "Tomato needed: " + recipeNeededTomato;
        carrotText.text = "Carrot needed: " + recipeNeededCarrot;

        playersCurrentBreadCount = playerIngredientsReference.currentPlayerBread.ToString();
        playersCurrentPotatoCount = playerIngredientsReference.currentPlayerPotato.ToString();
        playersCurrentTomatoCount = playerIngredientsReference.currentPlayerTomato.ToString();
        playersCurrentCarrotCount = playerIngredientsReference.currentPlayerCarrot.ToString();

        playerBreadText.text = "Bread: " + playersCurrentBreadCount;
        playerPotatoText.text = "Potato: " + playersCurrentPotatoCount;
        playerTomatoText.text = "Tomato: " + playersCurrentTomatoCount;
        playerCarrotText.text = "Carrot: " + playersCurrentCarrotCount;
    }
}
