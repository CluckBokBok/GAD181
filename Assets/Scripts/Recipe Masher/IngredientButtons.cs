using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientButtons : MonoBehaviour
{

    public GameObject MeatPopup;
    public bool MeatPopupActive = false;
    public GameObject VeggiesPopup;
    public bool VeggiesPopupActive = false;
    public GameObject DairyPopup;
    public bool DairyPopupActive = false;
    public GameObject PantryPopup;
    public bool PantryPopupActive = false;
    public Countdown countDown;

    public float animationDuration = 0.5f;
    public Vector2 hiddenPosition = new Vector2(125, -500);
    public Vector2 visiblePosition = new Vector2(125, -72);

    // dairy
    public GameObject milkDragIcon;
    public GameObject eggDragIcon;
    public GameObject cheeseDragIcon;

    // meat
    public GameObject fishDragIcon;
    public GameObject baconDragIcon;
    public GameObject tboneDragIcon;
    public GameObject sausageDragIcon;

    // vege
    public GameObject mushroomDragIcon;
    public GameObject broccoliDragIcon;
    public GameObject potatoDragIcon;
    public GameObject tomatoDragIcon;
    public GameObject carrotDragIcon;

    // pantry
    public GameObject pastaDragIcon;
    public GameObject sugarDragIcon;
    public GameObject flourDragIcon;
    public GameObject breadDragIcon;

    public float timeTakesToShowIcons = 2f;

    // Start is called before the first frame update
    void Start()
    {
        MeatPopup.transform.localPosition = hiddenPosition;
        VeggiesPopup.transform.localPosition = hiddenPosition;
        DairyPopup.transform.localPosition = hiddenPosition;
        PantryPopup.transform.localPosition = hiddenPosition;

        timeTakesToShowIcons = 0.5f;

        // dairy
        milkDragIcon.SetActive(false);
        eggDragIcon.SetActive(false);
        cheeseDragIcon.SetActive(false);

        // meat
        fishDragIcon.SetActive(false);
        baconDragIcon.SetActive(false);
        tboneDragIcon.SetActive(false);
        sausageDragIcon.SetActive(false);

        // vege
        mushroomDragIcon.SetActive(false);
        broccoliDragIcon.SetActive(false);
        potatoDragIcon.SetActive(false);
        tomatoDragIcon.SetActive(false);
        carrotDragIcon.SetActive(false);

        // pantry
        pastaDragIcon.SetActive(false);
        sugarDragIcon.SetActive(false);
        flourDragIcon.SetActive(false);
        breadDragIcon.SetActive(false);
     }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MeatButtonPress()
    {
        DeactivateOtherPopups("Meat");

        MeatPopupActive = !MeatPopupActive;
        MeatPopup.SetActive(MeatPopupActive);
        StartCoroutine(SlidePopup(MeatPopup, MeatPopupActive));

        // dairy
        milkDragIcon.SetActive(false);
        eggDragIcon.SetActive(false);
        cheeseDragIcon.SetActive(false);

        // meat
        fishDragIcon.SetActive(false);
        baconDragIcon.SetActive(false);
        tboneDragIcon.SetActive(false);
        sausageDragIcon.SetActive(false);

        // vege
        mushroomDragIcon.SetActive(false);
        broccoliDragIcon.SetActive(false);
        potatoDragIcon.SetActive(false);
        tomatoDragIcon.SetActive(false);
        carrotDragIcon.SetActive(false);

        // pantry
        pastaDragIcon.SetActive(false);
        sugarDragIcon.SetActive(false);
        flourDragIcon.SetActive(false);
        breadDragIcon.SetActive(false);

        if (MeatPopupActive)
        {
            StartCoroutine(WaitingForSlideBeforeShowingMeat());
        }
    }

    public void VeggiesButtonPress()
    {
        DeactivateOtherPopups("Veggies");

        VeggiesPopupActive = !VeggiesPopupActive;
        VeggiesPopup.SetActive(VeggiesPopupActive);
        StartCoroutine(SlidePopup(VeggiesPopup, VeggiesPopupActive));

        // dairy
        milkDragIcon.SetActive(false);
        eggDragIcon.SetActive(false);
        cheeseDragIcon.SetActive(false);

        // meat
        fishDragIcon.SetActive(false);
        baconDragIcon.SetActive(false);
        tboneDragIcon.SetActive(false);
        sausageDragIcon.SetActive(false);

        // vege
        mushroomDragIcon.SetActive(false);
        broccoliDragIcon.SetActive(false);
        potatoDragIcon.SetActive(false);
        tomatoDragIcon.SetActive(false);
        carrotDragIcon.SetActive(false);

        // pantry
        pastaDragIcon.SetActive(false);
        sugarDragIcon.SetActive(false);
        flourDragIcon.SetActive(false);
        breadDragIcon.SetActive(false);

        if (VeggiesPopupActive)
        {
            StartCoroutine(WaitingForSlideBeforeShowingVeggie());
        }
    }

        public void DairyButtonPress()
    {
        DeactivateOtherPopups("Dairy");

        DairyPopupActive = !DairyPopupActive;
        DairyPopup.SetActive(DairyPopupActive);
        StartCoroutine(SlidePopup(DairyPopup, DairyPopupActive));

        // dairy
        milkDragIcon.SetActive(false);
        eggDragIcon.SetActive(false);
        cheeseDragIcon.SetActive(false);

        // meat
        fishDragIcon.SetActive(false);
        baconDragIcon.SetActive(false);
        tboneDragIcon.SetActive(false);
        sausageDragIcon.SetActive(false);

        // vege
        mushroomDragIcon.SetActive(false);
        broccoliDragIcon.SetActive(false);
        potatoDragIcon.SetActive(false);
        tomatoDragIcon.SetActive(false);
        carrotDragIcon.SetActive(false);

        // pantry
        pastaDragIcon.SetActive(false);
        sugarDragIcon.SetActive(false);
        flourDragIcon.SetActive(false);
        breadDragIcon.SetActive(false);

        if (DairyPopupActive)
        {
            StartCoroutine(WaitingForSlideBeforeShowingDiary());
        }
    }

    public void PantryButtonPress()
    {
        DeactivateOtherPopups("Pantry");

        PantryPopupActive = !PantryPopupActive;
        PantryPopup.SetActive(PantryPopupActive);
        StartCoroutine(SlidePopup(PantryPopup, PantryPopupActive));

        // dairy
        milkDragIcon.SetActive(false);
        eggDragIcon.SetActive(false);
        cheeseDragIcon.SetActive(false);

        // meat
        fishDragIcon.SetActive(false);
        baconDragIcon.SetActive(false);
        tboneDragIcon.SetActive(false);
        sausageDragIcon.SetActive(false);

        // vege
        mushroomDragIcon.SetActive(false);
        broccoliDragIcon.SetActive(false);
        potatoDragIcon.SetActive(false);
        tomatoDragIcon.SetActive(false);
        carrotDragIcon.SetActive(false);

        // pantry
        pastaDragIcon.SetActive(false);
        sugarDragIcon.SetActive(false);
        flourDragIcon.SetActive(false);
        breadDragIcon.SetActive(false);

        if (PantryPopupActive)
        {
            StartCoroutine(WaitingForSlideBeforeShowingPantry());
        }
    }

    private void DeactivateOtherPopups(string activePopup)
    {
        if (activePopup != "Meat")
        {
            MeatPopupActive = false;
            MeatPopup.SetActive(false);
        }

        if (activePopup != "Veggies")
        {
            VeggiesPopupActive = false;
            VeggiesPopup.SetActive(false);
        }

        if (activePopup != "Dairy")
        {
            DairyPopupActive = false;
            DairyPopup.SetActive(false);
        }

        if (activePopup != "Pantry")
        {
            PantryPopupActive = false;
            PantryPopup.SetActive(false);
        }
    }

    private IEnumerator SlidePopup(GameObject popup, bool isVisible)
    {
        Vector2 startPosition = isVisible ? hiddenPosition : visiblePosition;
        Vector2 endPosition = isVisible ? visiblePosition : hiddenPosition;

        float elapsedTime = 0f;

        // Make sure the popup is active when sliding up
        if (isVisible)
            popup.SetActive(true);

        while (elapsedTime < animationDuration)
        {
            popup.transform.localPosition = Vector2.Lerp(startPosition, endPosition, elapsedTime / animationDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        popup.transform.localPosition = endPosition;

        // Make sure the popup is inactive when sliding down
        if (!isVisible)
            popup.SetActive(false);
    }

    private IEnumerator WaitingForSlideBeforeShowingDiary()
    {
        yield return new WaitForSeconds(timeTakesToShowIcons);

        if (DairyPopupActive)
        {
            // dairy
            milkDragIcon.SetActive(true);
            eggDragIcon.SetActive(true);
            cheeseDragIcon.SetActive(true);

            // meat
            fishDragIcon.SetActive(false);
            baconDragIcon.SetActive(false);
            tboneDragIcon.SetActive(false);
            sausageDragIcon.SetActive(false);

            // vege
            mushroomDragIcon.SetActive(false);
            broccoliDragIcon.SetActive(false);
            potatoDragIcon.SetActive(false);
            tomatoDragIcon.SetActive(false);
            carrotDragIcon.SetActive(false);

            // pantry
            pastaDragIcon.SetActive(false);
            sugarDragIcon.SetActive(false);
            flourDragIcon.SetActive(false);
            breadDragIcon.SetActive(false);
        }
    }

    private IEnumerator WaitingForSlideBeforeShowingMeat()
    {
        yield return new WaitForSeconds(timeTakesToShowIcons);

        if (MeatPopupActive)
        {
            // dairy
            milkDragIcon.SetActive(false);
            eggDragIcon.SetActive(false);
            cheeseDragIcon.SetActive(false);

            // meat
            fishDragIcon.SetActive(true);
            baconDragIcon.SetActive(true);
            tboneDragIcon.SetActive(true);
            sausageDragIcon.SetActive(true);

            // vege
            mushroomDragIcon.SetActive(false);
            broccoliDragIcon.SetActive(false);
            potatoDragIcon.SetActive(false);
            tomatoDragIcon.SetActive(false);
            carrotDragIcon.SetActive(false);

            // pantry
            pastaDragIcon.SetActive(false);
            sugarDragIcon.SetActive(false);
            flourDragIcon.SetActive(false);
            breadDragIcon.SetActive(false);
        }

    }

    private IEnumerator WaitingForSlideBeforeShowingVeggie()
    {
        yield return new WaitForSeconds(timeTakesToShowIcons);

        if (VeggiesPopupActive)
        {
            // dairy
            milkDragIcon.SetActive(false);
            eggDragIcon.SetActive(false);
            cheeseDragIcon.SetActive(false);

            // meat
            fishDragIcon.SetActive(false);
            baconDragIcon.SetActive(false);
            tboneDragIcon.SetActive(false);
            sausageDragIcon.SetActive(false);

            // vege
            mushroomDragIcon.SetActive(true);
            broccoliDragIcon.SetActive(true);
            potatoDragIcon.SetActive(true);
            tomatoDragIcon.SetActive(true);
            carrotDragIcon.SetActive(true);

            // pantry
            pastaDragIcon.SetActive(false);
            sugarDragIcon.SetActive(false);
            flourDragIcon.SetActive(false);
            breadDragIcon.SetActive(false);
        }
    }

    private IEnumerator WaitingForSlideBeforeShowingPantry()
    {
        yield return new WaitForSeconds(timeTakesToShowIcons);

        if (PantryPopupActive) 
        { 
            // dairy
            milkDragIcon.SetActive(false);
            eggDragIcon.SetActive(false);
            cheeseDragIcon.SetActive(false);

            // meat
            fishDragIcon.SetActive(false);
            baconDragIcon.SetActive(false);
            tboneDragIcon.SetActive(false);
            sausageDragIcon.SetActive(false);

            // vege
            mushroomDragIcon.SetActive(false);
            broccoliDragIcon.SetActive(false);
            potatoDragIcon.SetActive(false);
            tomatoDragIcon.SetActive(false);
            carrotDragIcon.SetActive(false);

            // pantry
            pastaDragIcon.SetActive(true);
            sugarDragIcon.SetActive(true);
            flourDragIcon.SetActive(true);
            breadDragIcon.SetActive(true);
        }
    }
}
