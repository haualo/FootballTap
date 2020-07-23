using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundControl : MonoBehaviour
{
    public AudioSource kickBall;
    public AudioSource cheerSound;
    public AudioSource hitBallFirstTime;


    private int scoreCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.isTouched || 
            dieControll.ballBounser ||
            boxRightControl.ballHitWallRight || 
            boxLeftControl.ballHitWallLeft)
        {
            kickBall.Play();

        }

   
        switch (pointController.scorePoint)
        {
            case 0: hitBallFirstTime.Play(); break;
            case 5: cheerSound.Play();  break;
            case 10: cheerSound.Play(); break;
            case 20: cheerSound.Play(); break;
            case 30: cheerSound.Play(); break;
            case 40: cheerSound.Play(); break;
            case 50: cheerSound.Play(); break;
            case 60: cheerSound.Play(); break;
            case 70: cheerSound.Play(); break;
            case 80: cheerSound.Play(); break;
            case 90: cheerSound.Play(); break;
            case 100: cheerSound.Play(); break;
            case 110: cheerSound.Play(); break;
            case 120: cheerSound.Play(); break;
            case 130: cheerSound.Play(); break;
            case 140: cheerSound.Play(); break;
            case 150: cheerSound.Play(); break;
            case 160: cheerSound.Play(); break;
            case 170: cheerSound.Play(); break;
            case 180: cheerSound.Play(); break;
            case 190: cheerSound.Play(); break;
            case 200: cheerSound.Play(); break;
            case 210: cheerSound.Play(); break;
            case 220: cheerSound.Play(); break;
            case 230: cheerSound.Play(); break;
            case 240: cheerSound.Play(); break;
            case 250: cheerSound.Play(); break;
            case 260: cheerSound.Play(); break;
            case 270: cheerSound.Play(); break;
            case 280: cheerSound.Play(); break;
            case 290: cheerSound.Play(); break;
            case 300: cheerSound.Play(); break;
            case 310: cheerSound.Play(); break;
            case 320: cheerSound.Play(); break;
            case 330: cheerSound.Play(); break;
            case 340: cheerSound.Play(); break;
            case 350: cheerSound.Play(); break;
            case 360: cheerSound.Play(); break;
            case 370: cheerSound.Play(); break;
            case 380: cheerSound.Play(); break;
            case 390: cheerSound.Play(); break;
            case 400: cheerSound.Play(); break;
            case 410: cheerSound.Play(); break;
            case 420: cheerSound.Play(); break;
            case 430: cheerSound.Play(); break;
            case 440: cheerSound.Play(); break;
            case 450: cheerSound.Play(); break;
            case 460: cheerSound.Play(); break;
            case 470: cheerSound.Play(); break;
            case 480: cheerSound.Play(); break;
            case 490: cheerSound.Play(); break;
            case 500: cheerSound.Play(); break;
            case 510: cheerSound.Play(); break;
            case 520: cheerSound.Play(); break;
            case 530: cheerSound.Play(); break;
            case 540: cheerSound.Play(); break;
            case 550: cheerSound.Play(); break;
        }

    }



}
