﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatingObject : MonoBehaviour
{
    public SpriteRenderer sprite;
    public float liteTimer;
    public bool isLiteSprite;
    
    // Start is called before the first frame update
    void Start()
    {
        if(!OptionsV2.LiteMode & !isLiteSprite)
        {
            LeanTween.moveY(gameObject, transform.position.y - 0.2f, .75f).setOnComplete(() =>
            {
                LeanTween.alpha(gameObject, 0, .45f).setDelay(1f).setOnComplete(() => { Song.instance.ratingsPool.Release(gameObject); });
            }).setEase(LeanTweenType.easeOutBounce);
        } else if (isLiteSprite)
        {
            sprite.enabled = false;
        }
    }


    private void Update()
    {
        if (!OptionsV2.LiteMode) return;
        sprite.enabled = !(liteTimer <= 0);
        liteTimer -= Time.deltaTime;
    }
}