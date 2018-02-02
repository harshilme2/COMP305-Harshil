using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAction : MonoBehaviour {

    public GameObject CaptainFalcon;
    public Sprite firstSprite;
    public Sprite secondSprite;
    
    private SpriteRenderer sRend;
    private Rigidbody2D rBody;
	// Use this for initialization
	void Start () {
        //Debug.Log(somenumber);
        rBody = CaptainFalcon.GetComponent<Rigidbody2D>();
        sRend = CaptainFalcon.GetComponent<SpriteRenderer>();

        rBody.velocity = new Vector2(2, 0);
    }

    // executes when mouse down event is fired on the attached object
    void OnMouseDown()
    {
        rBody.velocity *= -1;
        if(sRend.sprite == firstSprite)
        {
            sRend.sprite = secondSprite;
        }
        else
        {
            sRend.sprite = firstSprite;
        }
        
    }

}
