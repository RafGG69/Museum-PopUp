using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwapSprite : MonoBehaviour
{
    public SpriteRenderer realSprite;
    public Sprite defaultSprite;
    public Sprite targetSprite;
    public bool swapInteractable;

    void Start()
    {
        realSprite = gameObject.GetComponent<SpriteRenderer>();
    }

    public void Swap()
    {
        if (swapInteractable)
        {
            realSprite.sprite = targetSprite;
            swapInteractable = false;
        }
        else
        {
            realSprite.sprite = defaultSprite;
            swapInteractable = true;
        }
    }
}
