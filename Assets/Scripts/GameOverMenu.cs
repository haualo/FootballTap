using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using GoogleMobileAds.Api;
using System;

public class GameOverMenu : MonoBehaviour
{

    private RewardedAd rewardedAd;
    public string rewardAdID;

    public static bool continueIsPressed = false;

    private bool pressContinue = false;
    public GameObject gameOverUI;

    //sound --speical way--
    private bool playNewHighScore = false;
    public GameObject soundNewHighScore;
    public GameObject SoundLose;
    public GameObject newHighScoreLabel;

    public Text currentScoreLabel;
    public Text highScoreLabel;

    private int currentScore;
    private int highScore;

    // Start is called before the first frame update
    void Start()
    {

        highScore = PlayerPrefs.GetInt("HighScore", 0);
        // Get singleton reward based video ad reference.
        //this.rewardedAd = new RewardedAd("ca-app-pub-3940256099942544/5224354917");
        
        this.rewardedAd = new RewardedAd(rewardAdID);
        // Called when the user should be rewarded for interacting with the ad.
        this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        // Called when the ad is closed.
        this.rewardedAd.OnAdClosed += HandleRewardedAdClosed;

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded ad with the request.
        this.rewardedAd.LoadAd(request);
    }

    private void UserChoseToWatchAd()
    {
        if (this.rewardedAd.IsLoaded())
        {
            this.rewardedAd.Show();
        }
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {
        string type = args.Type;
        double amount = args.Amount;
        MonoBehaviour.print(
            "HandleRewardedAdRewarded event received for "
                        + amount.ToString() + " " + type);


        pointController.scorePoint = currentScore;
        continueIsPressed = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        dieControll.isGameOver = false;
    }
    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdClosed event received");
        if (continueIsPressed)
        {
            pressContinue = false;

            UserChoseToWatchAd();
        }

    }


    // Update is called once per frame
    void Update()
    {
        currentScore = pointController.scorePoint;
        if (currentScore > highScore)
        {
            PlayerPrefs.SetInt("HighScore", currentScore);
            highScore = currentScore;
            playNewHighScore = true;
        }

        if (playNewHighScore)
        {
            newHighScoreLabel.SetActive(true);
            soundNewHighScore.SetActive(true);
            SoundLose.SetActive(false);
        }
        else
        {

            newHighScoreLabel.SetActive(false);
            soundNewHighScore.SetActive(false);
            SoundLose.SetActive(true);
        }

        
        currentScoreLabel.text = currentScore.ToString();
        highScoreLabel.text = "Best: " + highScore.ToString();

        if (dieControll.isGameOver)
        {
            GameOver();

        }


    }

    private void GameOver()
    {
        gameOverUI.SetActive(true);

    }

    public void OkButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1 );
        dieControll.isGameOver = false;

    }

    public void ContinueButton()
    {

        UserChoseToWatchAd();
        pressContinue = true;

    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
