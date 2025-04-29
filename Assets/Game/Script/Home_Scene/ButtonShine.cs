using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonShine : MonoBehaviour
{
    public RectTransform shineTransform; // Assign the ShineEffect RectTransform in Inspector
    public float speed = 300f;

    private float startX;
    private float endX;

    void Start()
    {
        // Get width of the button
        float width = GetComponent<RectTransform>().rect.width;

        // Set start and end positions for the shine
        startX = -width;
        endX = width;
    }

    void Update()
    {
        // Move shine
        Vector3 pos = shineTransform.localPosition;
        pos.x += speed * Time.deltaTime;

        if (pos.x > endX)
            pos.x = startX;

        shineTransform.localPosition = pos;
    }
}

