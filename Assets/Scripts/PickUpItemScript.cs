using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PickUpItemScript : MonoBehaviour
{
    [SerializeField] protected Image itemImageHolder;
    protected int activeItemIndex = -1;
    protected List<Color> items = new List<Color>();



     private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item")) {
            PickUpItem(other.gameObject);
        }
    }

void PickUpItem(GameObject item) {

        Color color = item.gameObject.GetComponent<Renderer>().material.color;

        Destroy(item);

        items.Add(color);

        activeItemIndex = items.Count - 1;

        itemImageHolder.color = items[activeItemIndex];
        itemImageHolder.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
