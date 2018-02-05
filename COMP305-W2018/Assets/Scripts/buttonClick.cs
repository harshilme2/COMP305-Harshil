using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonClick : MonoBehaviour {

    public GameObject cBoy;
    //public Sprite redSprite;
    //public Sprite blueSprite;
    //public Sprite greenSprite;
    public Sprite newSprite;
    private SpriteRenderer sRend;
    
    // Use this for initialization
    void Start () {
       
        sRend = cBoy.GetComponent<SpriteRenderer>();

    }

    void OnMouseDown()
    {
        sRend.sprite = newSprite;

    }

}
