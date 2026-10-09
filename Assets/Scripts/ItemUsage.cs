using UnityEngine;

public class ItemUsage : PickUpItemScript
{
    [SerializeField] private UIController uiController;
    [SerializeField] private ShootScript shootScript;
    [SerializeField] private MoveScript moveScript;

void UseItem()
{
    // Eén duidelijke check als je op E drukt
    if (Input.GetKeyDown(KeyCode.E) && items.Count > 0 && activeItemIndex != -1) 
    {
        // 1. Blauw item
        if (items[activeItemIndex] == Color.blue) 
        {
            uiController.StartCoroutine(uiController.ShowMessage(" + Move Speed"));
            moveScript.moveSpeed += 50;
        }
        // 2. Rood item
        else if (items[activeItemIndex] == Color.red)
        {
            uiController.StartCoroutine(uiController.ShowMessage(" + Fire Rate"));
            shootScript.cooldownTime -= 0.1f;
        }
        // 3. Groen item
        else if (items[activeItemIndex] == Color.green)
        {
            uiController.StartCoroutine(uiController.ShowMessage(" + Rotation Speed"));
            moveScript.rotationSpeed += 90; // 10 of 20 is nu weer genoeg!
        } 

        // Daarna het item verwijderen uit de lijst
        items.RemoveAt(activeItemIndex);            
        if (activeItemIndex > 0)
        {
            activeItemIndex--;
            itemImageHolder.color = items[activeItemIndex];
        }
        else if (items.Count == 0)
        {
            itemImageHolder.color = Color.white;
            activeItemIndex = -1;
            itemImageHolder.enabled = false;
        }
    }
}

    // Update is called once per frame
    void Update()
    {
        UseItem();
    }
}
