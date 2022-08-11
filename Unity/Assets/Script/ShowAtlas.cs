using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class ShowAtlas : MonoBehaviour
{
    // Start is called before the first frame update
    public Image img;
    private float f;
    void Start()
    {
        img = this.transform.GetComponentInChildren<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        int i = (int)f%11;
        SpriteAtlas spriteAtlas = Resources.Load<SpriteAtlas>("atlas");
        Debug.Log(spriteAtlas == null);
        img.sprite = spriteAtlas.GetSprite(i.ToString());
        f = f + Time.deltaTime;
    }
}
