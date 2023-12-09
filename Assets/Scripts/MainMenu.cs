using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string gameScene = "GameScene"; // Дефиниране на променлива gameScene със стойност "GameScene".
    public GameObject gameTitle; // Дефиниране на обект gameTitle.
    public GameObject optionsText; // Дефиниране на обект optionsText.
    public GameObject generalText; // Дефиниране на обект generalText.
    public GameObject audioText; // Дефиниране на обект audioText.
    public GameObject videoText; // Дефиниране на обект videoText.
    public GameObject startButton; // Дефиниране на обект startButton.
    public GameObject optionsButton; // Дефиниране на обект optionsButton.
    public GameObject quitButton; // Дефиниране на обект quitButton.
    public GameObject backButton; // Дефиниране на обект backButton.
    public GameObject backOptionsButton; // Дефиниране на обект backOptionsButton.
    public GameObject generalButton; // Дефиниране на обект generalButton.
    public GameObject audioButton; // Дефиниране на обект auidoButton.
    public GameObject videoButton; // Дефиниране на обект videoButton.

    // Старт се извиква преди първия фрейм.
    void Start()
    {
        gameTitle.SetActive(true); // Скриване на gameTitle.
        optionsText.SetActive(false); // Скриване на optionsText.
        generalText.SetActive(false); // Скриване на generalText.
        audioText.SetActive(false); // Скриване на audioText.
        videoText.SetActive(false); // Скриване на videoText.
        startButton.SetActive(true); // Показване на startButton.
        optionsButton.SetActive(true); // Показване на optiosnButton.
        quitButton.SetActive(true); // Показване на quitButton.
        backButton.SetActive(false); // Скриване на backButton.
        backOptionsButton.SetActive(false); // Скриване на backOptionsButton.
        generalButton.SetActive(false); // Скриване на generalButton.
        audioButton.SetActive(false); // Скриване на audioButton.
        videoButton.SetActive(false); // Скриване на videoButton.
    }

    // Update се извиква веднъж за всеки фрейм.
    void Update()
    {
        
    }

    public void OnStartButtonPressed() // Създаване на метод OnStartButtonPressed().
    {
        SceneManager.LoadScene(gameScene); // Промяна на сцената на gameScene.
    }

    public void OnOptionsButtonPressed() // Създаване на метод OnOptionsButtonPressed().
    {
        gameTitle.SetActive(false); // Скриване на gameTitle.
        optionsText.SetActive(true); // Показване на optionsText.
        generalText.SetActive(false); // Скриване на generalText.
        audioText.SetActive(false); // Скриване на audioText.
        videoText.SetActive(false); // Скриване на videoText.
        startButton.SetActive(false); // Скриване на startButton.
        optionsButton.SetActive(false); // Скриване на optionsButton.
        quitButton.SetActive(false); // Скриване на quitButton.
        backButton.SetActive(true); // Показване на backButton.
        backOptionsButton.SetActive(false); // Скриване на backOptionsButton.
        generalButton.SetActive(true); // Показване на generalButton.
        audioButton.SetActive(true); // Показване на audioButton.
        videoButton.SetActive(true); // Показване на videoButton.
    }

    public void OnQuitButtonPressed() // Създаване на метод OnQuitButtonPressed().
    {
        Application.Quit(); // Излизане от апликацията.
    }

    public void OnBackButtonPressed() // Създаване на метод OnBackButtonPressed().
    {
        gameTitle.SetActive(true);
        optionsText.SetActive(false); // Скриване на optionsText.
        generalText.SetActive(false); // Скриване на generalText.
        audioText.SetActive(false); // Скриване на audioText.
        videoText.SetActive(false); // Скриване на videoText.
        startButton.SetActive(true); // Показване на startButton.
        optionsButton.SetActive(true); // Показване на optionsButton.
        quitButton.SetActive(true); // Показване на quitButton.
        backButton.SetActive(false); // Скриване на backButton.
        backOptionsButton.SetActive(false); // Скриване на backOptionsButton.
        generalButton.SetActive(false); // Скриване на generalButton.
        audioButton.SetActive(false); // Скриване на audioButton.
        videoButton.SetActive(false); // Скриване на videoButton.
    }

    public void OnBackOptionsButtonPressed() // Създаване на метод OnBackOptionsButtonPressed().
    {
        gameTitle.SetActive(false); // Скриване на gameTitle.
        optionsText.SetActive(true); // Показване на optionsText.
        generalText.SetActive(false); // Скриване на generalText.
        audioText.SetActive(false); // Скриване на audioText.
        videoText.SetActive(false); // Скриване на videoText.
        startButton.SetActive(false); // Скриване на startButton.
        optionsButton.SetActive(false); // Скриване на optionsButton.
        quitButton.SetActive(false); // Скриване на quitButton.
        backButton.SetActive(true); // Показване на backButton.
        backOptionsButton.SetActive(false); // Скриване на backOptionsButton.
        generalButton.SetActive(true); // Показване на generalButton.
        audioButton.SetActive(true); // Показване на audioButton.
        videoButton.SetActive(true); // Показване на videoButton.
    }

    public void OnGeneralButtonPressed() // Създаване на метод OnGeneralButtonPressed().
    {
        gameTitle.SetActive(false); // Скриване на gameTitle.
        optionsText.SetActive(false); // Скриване на optionsText.
        generalText.SetActive(true);  // Показване на generalText.
        audioText.SetActive(false); // Скриване на audiotext.
        videoText.SetActive(false); // Скриване на videoText.
        startButton.SetActive(false); // Скриване на startButton.
        optionsButton.SetActive(false); // Скриване на optionsButton.
        quitButton.SetActive(false); // Скриване на quitButton.
        backButton.SetActive(false); // Скриване на backButton.
        backOptionsButton.SetActive(true); // Показване на backOptionsButton
        generalButton.SetActive(false); // Скриване на generalButton.
        audioButton.SetActive(false); // Скриване на audioButton.
        videoButton.SetActive(false); // Скриване на videoButton.
    }

    public void OnAudioButtonPressed() // Създаване на метод OnAudioButtonPressed().
    {
        gameTitle.SetActive(false); // Скриване на gameTitle.
        optionsText.SetActive(false); // Скриване на optionsText.
        generalText.SetActive(false); // Скриване на generalText.
        audioText.SetActive(true); // Показване на audioText.
        videoText.SetActive(false); // Скриване на videoText
        startButton.SetActive(false); // Скриване на startButton.
        optionsButton.SetActive(false); // Скриване на optionsButton.
        quitButton.SetActive(false); // Скриване на quitButton.
        backButton.SetActive(false); // Скриване на backButton.
        backOptionsButton.SetActive(true); // Показване на backOptionsButton.
        generalButton.SetActive(false); // Скриване на generalButton.
        audioButton.SetActive(false); // Скриване на audioButton.
        videoButton.SetActive(false); // Скриване на videoButton.
    }

    public void OnVideoButtonPressed() // Създаване на метод OnVideoButtonPressed().
    {
        gameTitle.SetActive(false); // Скриване на gameTitle.
        optionsText.SetActive(false); // Скриване на optionsText.
        generalText.SetActive(false); // Скриване на generalText.
        audioText.SetActive(false); // Скриване на audioText.
        videoText.SetActive(true); // Показване на videoText.
        startButton.SetActive(false); // Скриване на startButton.
        optionsButton.SetActive(false); // Скриване на optionsButton.
        quitButton.SetActive(false); // Скриване на quitButton.
        backButton.SetActive(false); // Скриване на backButton.
        backOptionsButton.SetActive(true); // Показване на backOptionsButton.
        generalButton.SetActive(false); // Скриване на generalButton.
        audioButton.SetActive(false); // Скриване на audioButton.
        videoButton.SetActive(false); // Скриване на videoButton.
    }
}
