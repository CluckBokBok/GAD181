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
    [SerializeField] private string recipeNeededCheese;
    [SerializeField] private string recipeNeededSausage;
    [SerializeField] private string recipeNeededMushroom;
    [SerializeField] private string recipeNeededTbone;
    [SerializeField] private string recipeNeededBacon;
    [SerializeField] private string recipeNeededFlour;
    [SerializeField] private string recipeNeededMilk;
    [SerializeField] private string recipeNeededPasta;
    [SerializeField] private string recipeNeededSugar;
    [SerializeField] private string recipeNeededEgg;
    [SerializeField] private string recipeNeededFish;
    [SerializeField] private string recipeNeededBroccoli;

    [SerializeField] private TextMeshProUGUI breadText;
    [SerializeField] private TextMeshProUGUI potatoText;
    [SerializeField] private TextMeshProUGUI tomatoText;
    [SerializeField] private TextMeshProUGUI carrotText;
    [SerializeField] private TextMeshProUGUI CheeseText;
    [SerializeField] private TextMeshProUGUI SausageText;
    [SerializeField] private TextMeshProUGUI MushroomText;
    [SerializeField] private TextMeshProUGUI TboneText;
    [SerializeField] private TextMeshProUGUI BaconText;
    [SerializeField] private TextMeshProUGUI FlourText;
    [SerializeField] private TextMeshProUGUI MilkText;
    [SerializeField] private TextMeshProUGUI PastaText;
    [SerializeField] private TextMeshProUGUI SugarText;
    [SerializeField] private TextMeshProUGUI EggText;
    [SerializeField] private TextMeshProUGUI FishText;
    [SerializeField] private TextMeshProUGUI BroccoliText;

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
        recipeNeededCheese = setRecipeReference.currentRecipeCheese.ToString();
        recipeNeededSausage = setRecipeReference.currentRecipeSausage.ToString();
        recipeNeededMushroom = setRecipeReference.currentRecipeMushroom.ToString();
        recipeNeededTbone = setRecipeReference.currentRecipeTBone.ToString();
        recipeNeededBacon = setRecipeReference.currentRecipeBacon.ToString();
        recipeNeededFlour = setRecipeReference.currentRecipeFlour.ToString();
        recipeNeededMilk = setRecipeReference.currentRecipeMilk.ToString();
        recipeNeededPasta = setRecipeReference.currentRecipePasta.ToString();
        recipeNeededSugar = setRecipeReference.currentRecipeSugar.ToString();
        recipeNeededEgg = setRecipeReference.currentRecipeEgg.ToString();
        recipeNeededFish = setRecipeReference.currentRecipeFish.ToString();
        recipeNeededBroccoli = setRecipeReference.currentRecipeBroccoli.ToString();

        breadText.text = "x " + recipeNeededBread;
        potatoText.text = "x " + recipeNeededPotato;
        tomatoText.text = "x " + recipeNeededTomato;
        carrotText.text = "x " + recipeNeededCarrot;
        CheeseText.text = "x " + recipeNeededCheese;
        SausageText.text = "x " + recipeNeededSausage;
        MushroomText.text = "x " + recipeNeededMushroom;
        TboneText.text = "x " + recipeNeededTbone;
        BaconText.text = "x " + recipeNeededBacon;
        FlourText.text = "x " + recipeNeededFlour;
        MilkText.text = "x " + recipeNeededMilk;
        PastaText.text = "x " + recipeNeededPasta;
        SugarText.text = "x " + recipeNeededSugar;
        EggText.text = "x " + recipeNeededEgg;
        FishText.text = "x " + recipeNeededFish;
        BroccoliText.text = "x " + recipeNeededBroccoli;

        //playersCurrentBreadCount = playerIngredientsReference.currentPlayerBread.ToString();
        //playersCurrentPotatoCount = playerIngredientsReference.currentPlayerPotato.ToString();
        //playersCurrentTomatoCount = playerIngredientsReference.currentPlayerTomato.ToString();
        //playersCurrentCarrotCount = playerIngredientsReference.currentPlayerCarrot.ToString();

        //playerBreadText.text = "Bread: " + playersCurrentBreadCount;
        //playerPotatoText.text = "Potato: " + playersCurrentPotatoCount;
        //playerTomatoText.text = "Tomato: " + playersCurrentTomatoCount;
        //playerCarrotText.text = "Carrot: " + playersCurrentCarrotCount;
    }

    public void RecipeReset()
    {
        breadText.text = "x " + recipeNeededBread;
        potatoText.text = "x " + recipeNeededPotato;
        tomatoText.text = "x " + recipeNeededTomato;
        carrotText.text = "x " + recipeNeededCarrot;
        CheeseText.text = "x " + recipeNeededCheese;
        SausageText.text = "x " + recipeNeededSausage;
        MushroomText.text = "x " + recipeNeededMushroom;
        TboneText.text = "x " + recipeNeededTbone;
        BaconText.text = "x " + recipeNeededBacon;
        FlourText.text = "x " + recipeNeededFlour;
        MilkText.text = "x " + recipeNeededMilk;
        PastaText.text = "x " + recipeNeededPasta;
        SugarText.text = "x " + recipeNeededSugar;
        EggText.text = "x " + recipeNeededEgg;
        FishText.text = "x " + recipeNeededFish;
        BroccoliText.text = "x " + recipeNeededBroccoli;
    }
}
