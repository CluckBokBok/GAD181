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

    // Start is called before the first frame update
    void Start()
    {
        MeatPopup.transform.localPosition = hiddenPosition;
        VeggiesPopup.transform.localPosition = hiddenPosition;
        DairyPopup.transform.localPosition = hiddenPosition;
        PantryPopup.transform.localPosition = hiddenPosition;
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
    }

    public void VeggiesButtonPress()
    {
        DeactivateOtherPopups("Veggies");

        VeggiesPopupActive = !VeggiesPopupActive;
        VeggiesPopup.SetActive(VeggiesPopupActive);
        StartCoroutine(SlidePopup(VeggiesPopup, VeggiesPopupActive));
    }

    public void DairyButtonPress()
    {
        DeactivateOtherPopups("Dairy");

        DairyPopupActive = !DairyPopupActive;
        DairyPopup.SetActive(DairyPopupActive);
        StartCoroutine(SlidePopup(DairyPopup, DairyPopupActive));
    }

    public void PantryButtonPress()
    {
        DeactivateOtherPopups("Pantry");

        PantryPopupActive = !PantryPopupActive;
        PantryPopup.SetActive(PantryPopupActive);
        StartCoroutine(SlidePopup(PantryPopup, PantryPopupActive));
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
}
