using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsSetup : MonoBehaviour
{
    private Vector3 screenSize;
    private Vector3 screenBounds;
    public GameObject leftWall;
    public GameObject rightWall;
    public GameObject topWall;
    public GameObject bottomWall;
    public GameObject PointsA;
    public GameObject PointsB;
    public GameObject bg;


    // Start is called before the first frame update
    void Start()
    {
        screenSize = new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z);
        screenBounds = Camera.main.ScreenToWorldPoint(screenSize);
        leftWall.transform.position = new Vector2(screenBounds.x * -1, 0f);
        leftWall.transform.localScale = new Vector2(screenSize.y,leftWall.transform.localScale.y);

        rightWall.transform.position = new Vector2(screenBounds.x, 0f);
        rightWall.transform.localScale = new Vector2(screenSize.y, rightWall.transform.localScale.y);

        topWall.transform.position = new Vector2(0f,screenBounds.y);
        topWall.transform.localScale = new Vector2(screenSize.x,topWall.transform.localScale.y);

        bottomWall.transform.position = new Vector2(0f,screenBounds.y * -1);
        bottomWall.transform.localScale = new Vector2(screenSize.x, topWall.transform.localScale.y);

        PointsA.transform.position = new Vector2(screenBounds.x - 2.52f, 0f);
        PointsB.transform.position = new Vector2(PointsA.transform.position.x -3f, 0f);
        bg.transform.localScale = new Vector2(screenSize.x, screenSize.y);
    }

    // Update is called once per frame
    void Update()
    {
        leftWall.transform.position = new Vector2(screenBounds.x * -1, 0f);
        leftWall.transform.localScale = new Vector2(screenSize.y, leftWall.transform.localScale.y);

        rightWall.transform.position = new Vector2(screenBounds.x, 0f);
        rightWall.transform.localScale = new Vector2(screenSize.y, rightWall.transform.localScale.y);

        topWall.transform.position = new Vector2(0f, screenBounds.y);
        topWall.transform.localScale = new Vector2(screenSize.x, topWall.transform.localScale.y);

        bottomWall.transform.position = new Vector2(0f, screenBounds.y * -1);
        bottomWall.transform.localScale = new Vector2(screenSize.x, topWall.transform.localScale.y);

        PointsA.transform.position = new Vector2(screenBounds.x - 2.52f, 0f);
        PointsB.transform.position = new Vector2(PointsA.transform.position.x -3f, 0f);
    }
}
