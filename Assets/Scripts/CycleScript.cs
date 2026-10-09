using UnityEngine;

public class CycleScript : PickUpItemScript
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void CycleItems() {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (items.Count > 0)
            {
                if (activeItemIndex < items.Count - 1)
                {
                    activeItemIndex++;
                }
                else
                {
                    activeItemIndex = 0;
                }
                itemImageHolder.color = items[activeItemIndex];
            }
            else
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
        CycleItems();
    }
}
