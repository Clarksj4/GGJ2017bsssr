﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour {

    private Bat bat;

    private Vector3 screenPosition;
    private float yDistanceToScreenTop;
    private float xDistanceToScreenSide;

    void Awake()
    {
        bat = GetComponent<Bat>();
    }

    void Start()
    {
        screenPosition = Camera.main.WorldToScreenPoint(bat.transform.position);
        yDistanceToScreenTop = Screen.height - screenPosition.y;
        xDistanceToScreenSide = Screen.width / 2;
    }

	// Update is called once per frame
	void Update ()
    {
        float yDistanceFromBat = Input.mousePosition.y - screenPosition.y;
        float yDelta = yDistanceFromBat / yDistanceToScreenTop;

        bat.Move(yDelta);

        float xDistanceFromBat = Input.mousePosition.x - screenPosition.x;
        float xDelta = xDistanceFromBat / xDistanceToScreenSide;

        bat.Turn(xDelta);
    }
}
