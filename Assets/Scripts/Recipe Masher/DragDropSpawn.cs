using SAE.GAD181.Game3;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public SpawnedIngredientHolder spawnedIngredientHolderReference;
    public PlayerIngredients PlayerIngredientsReference;

    private bool isDragging;
    private Vector3 initialPosition;
    private Camera cam;
    private Vector3 offset;

    public GameObject thePrefabThatIsBeingInstantiated;
    private GameObject theObjectThatsCurrentlyInstantiated;
    public Transform whereObjectIsBeingSpawned;

    private GameObject newlySpawnedObject;

    private Rigidbody2D spawnedIngredientRigidBody2D;


    private void Start()
    {
        cam = Camera.main;
        initialPosition = transform.position; 
    }

    private void OnMouseDown()
    {
        isDragging = true;
        Vector3 mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        offset = transform.position - mousePosition;
        GetComponent<SpriteRenderer>().enabled = false;
        InstantiatingCyclinderAsSubstitute();
    }

    private void OnMouseDrag()
    {
        if (isDragging)
        {
            Cursor.visible = false;
            Vector3 mousePosition = cam.ScreenToWorldPoint(Input.mousePosition) + offset;
            mousePosition.z = 0; // Ensures the object stays in the 2D plane
            transform.position = mousePosition;
            if (theObjectThatsCurrentlyInstantiated != null)
            {
                theObjectThatsCurrentlyInstantiated.transform.position = mousePosition;
            }
        }
    }

    private void OnMouseUp()
    {
        isDragging = false;
        Cursor.visible = true;

        Collider2D[] colliders = Physics2D.OverlapPointAll(transform.position);

        transform.position = initialPosition;

        GetComponent<SpriteRenderer>().enabled = true;

        Destroy(theObjectThatsCurrentlyInstantiated);

        foreach (Collider2D collider in colliders)
        {
            if (collider.CompareTag("PlateZone"))
            {
                // Identify the dropped ingredient (assuming the tag or name represents the ingredient)
                string droppedIngredient = gameObject.tag; // or gameObject.name

                // Process the ingredient in the PlateZone
                HandleIngredientDrop(droppedIngredient);

                // Resets the position
                transform.position = initialPosition;

                // Instantiate a new object
                newlySpawnedObject = Instantiate(thePrefabThatIsBeingInstantiated, new Vector3(Random.Range(-2.6f, 2.5f), 3, 0), Quaternion.Euler(0,0, Random.Range(1f,179f)));

                //newlySpawnedObject.GetComponent<Rigidbody2D>().AddTorque(transform.rotation.z * 1000000); - trying to make the object spin still work in progress

                newlySpawnedObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                newlySpawnedObject.GetComponent<CircleCollider2D>().isTrigger = false;

                if (droppedIngredient == "Bread")
                {
                    Debug.Log("The bread is in the plate");
                    spawnedIngredientHolderReference.breadHolder.Add(newlySpawnedObject);
                    PlayerIngredientsReference.AddPlayerBread(1);
                }
                else if (droppedIngredient == "Potato")
                {
                    Debug.Log("The Potato is in the plate");
                    spawnedIngredientHolderReference.potatoHolder.Add(newlySpawnedObject);
                    PlayerIngredientsReference.AddPlayerPotato(1);
                }
                else if (droppedIngredient == "Tomato")
                {
                    Debug.Log("The Tomato is in the plate");
                    spawnedIngredientHolderReference.tomatoHolder.Add(newlySpawnedObject);
                    PlayerIngredientsReference.AddPlayerTomato(1);
                }
                else if (droppedIngredient == "Carrot")
                {
                    Debug.Log("The Carrot is in the plate");
                    spawnedIngredientHolderReference.carrotHolder.Add(newlySpawnedObject);
                    PlayerIngredientsReference.AddPlayerCarrot(1);
                }
                else if(droppedIngredient == "Flour")
                {
                    Debug.Log("The Flour is in the plate");
                    spawnedIngredientHolderReference.carrotHolder.Add(newlySpawnedObject);
                    PlayerIngredientsReference.AddPlayerFlour(1);
                }
                else if (droppedIngredient == "Sugar")
                {
                    Debug.Log("The Sugar is in the plate");
                    spawnedIngredientHolderReference.carrotHolder.Add(newlySpawnedObject);
                    PlayerIngredientsReference.AddPlayerSugar(1);
                }
                else if (droppedIngredient == "Pasta")
                {
                    Debug.Log("The Pasta is in the plate");
                    spawnedIngredientHolderReference.carrotHolder.Add(newlySpawnedObject);
                    PlayerIngredientsReference.AddPlayerPasta(1);
                }
                else if (droppedIngredient == "Broccoli")
                {
                    Debug.Log("The Broccoli is in the plate");
                    spawnedIngredientHolderReference.carrotHolder.Add(newlySpawnedObject);
                    PlayerIngredientsReference.AddPlayerBrocolli(1);
                }
                else if (droppedIngredient == "Mushroom")
                {
                    Debug.Log("The Mushroom is in the plate");
                    spawnedIngredientHolderReference.carrotHolder.Add(newlySpawnedObject);
                    PlayerIngredientsReference.AddPlayerMushroom(1);
                }
                else if (droppedIngredient == "Sausage")
                {
                    Debug.Log("The Sausage is in the plate");
                    spawnedIngredientHolderReference.carrotHolder.Add(newlySpawnedObject);
                    PlayerIngredientsReference.AddPlayerSausage(1);
                }
                else if (droppedIngredient == "Tbone")
                {
                    Debug.Log("The Tbone is in the plate");
                    spawnedIngredientHolderReference.carrotHolder.Add(newlySpawnedObject);
                    PlayerIngredientsReference.AddPlayerTBone(1);
                }
                else if (droppedIngredient == "Bacon")
                {
                    Debug.Log("The Bacon is in the plate");
                    spawnedIngredientHolderReference.carrotHolder.Add(newlySpawnedObject);
                    PlayerIngredientsReference.AddPlayerBacon(1);
                }
                else if (droppedIngredient == "Fish")
                {
                    Debug.Log("The Fish is in the plate");
                    spawnedIngredientHolderReference.carrotHolder.Add(newlySpawnedObject);
                    PlayerIngredientsReference.AddPlayerFish(1);
                }
                else if (droppedIngredient == "Milk")
                {
                    Debug.Log("The Milk is in the plate");
                    spawnedIngredientHolderReference.carrotHolder.Add(newlySpawnedObject);
                    PlayerIngredientsReference.AddPlayerMilk(1);
                }
                else if (droppedIngredient == "Egg")
                {
                    Debug.Log("The Egg is in the plate");
                    spawnedIngredientHolderReference.carrotHolder.Add(newlySpawnedObject);
                    PlayerIngredientsReference.AddPlayerEgg(1);
                }
                else if (droppedIngredient == "Cheese")
                {
                    Debug.Log("The Cheese is in the plate");
                    spawnedIngredientHolderReference.carrotHolder.Add(newlySpawnedObject);
                    PlayerIngredientsReference.AddPlayerCheese(1);
                }

                break;
            }
        }
    }

    public void InstantiatingCyclinderAsSubstitute()
    {
        theObjectThatsCurrentlyInstantiated = Instantiate(thePrefabThatIsBeingInstantiated,whereObjectIsBeingSpawned.position, Quaternion.identity);
        Vector3 currentScale = theObjectThatsCurrentlyInstantiated.transform.localScale;
        Vector3 newScale = new Vector3(currentScale.x = 0.5f, currentScale.y = 0.5f, currentScale.z = -0.1f);
        theObjectThatsCurrentlyInstantiated.transform.localScale = newScale;
    }

    private void HandleIngredientDrop(string ingredient)
    {
        // Handle the logic based on the dropped ingredient
        Debug.Log("Dropped ingredient: " + ingredient);
        // Add further processing logic as needed
    }
}