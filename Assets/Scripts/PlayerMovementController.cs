using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovementController : MonoBehaviour
{
    public string menuScene = "MainMenu"; // Дефиниране на променлива със стойност "MainMenu".
    public GameObject winnerText; // Дефиниране на обект за текст, на който пише че сме победили.
    [SerializeField] private float jumpForce = 8.0f; // Дефиниране на променлива jumpForce, която е със стойност 8.
    [SerializeField] private float speed = 100.0f; // Дефиниране на променлива speed със стойност 100.
    [SerializeField] private float swimSpeed = 100.0f; // Дефиниране на променлива swimSpeed със стойност 10.
    [SerializeField] private float sprintSpeed = 300.0f; // Дефиниране на променлива sprintSpeed със стойност 300.
    private bool canWalk = true; // Дефиниране на променлива canWalk със стойност true.н
    private bool canSwim = false; // Дефиниране на променлива canSwim със стойност false.
    private bool canJump = false; // Дефиниране на променлива canJump със стойност false.
    private bool canJump2 = false; // Дефиниране на променлива canJump2 със стойност false.
    public bool isLayer2 = false; // Дефиниране на промелива isLayer2 със стойност false.
    private Rigidbody rb; // Дефиниране на обект Rigidbody.
    private bool canSprint = true; // Дефиниране на променлива canSprint със стойност true.
    private bool antigrav = false; // Дефиниране на променлива antigrav със стойност false.
    private bool canAntigrav = true; // Дефиниране на променлива canAntigrav със стойност true.
    private bool IsSprinting => canSprint && Input.GetKey(KeyCode.LeftShift); // Дефиниране наю променлива IsSprinting, която е вярна, ако canSprint е вярно и сме натиснали бутона LeftShift.
    public GameObject portal1; // Дефиниране на обект за портал.
    public GameObject portal2; // Дефиниране на обект за портал.
    public GameObject bluePortal1; // Дефиниране на обект за портал.
    public GameObject bluePortal2; // Дефиниране на обект за портал.
    public GameObject orangePortal1; // Дефиниране на обект за портал.
    public GameObject orangePortal2; // Дефиниране на обект за портал.
    public GameObject camera; // Дефинираш обект за камера.
    
    // Старт се извиква преди първия фрейм.
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Взима компонент от тип Rigidbody.
        winnerText.SetActive(false); // Скрива текста.
    }

    // Update се извиква веднъж за всеки фрейм.
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A)) // Проверява дали е натиснат клавиш A.
        {
            // Калкулиране на скорост на движение на героя наляво.
            rb.velocity = new Vector3(-(IsSprinting ? sprintSpeed : speed) * Time.deltaTime, rb.velocity.y, rb.velocity.z);
        }

        if (Input.GetKey(KeyCode.D)) // Проверява дали е натиснат клавиш D.
       {
        // Калкулиране на скорост на движение на героя надясно.
        rb.velocity = new Vector3((IsSprinting ? sprintSpeed : speed) * Time.deltaTime, rb.velocity.y, rb.velocity.z);
       }
    }
    // Update се извиква веднъж за всеки фрейм.

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // Проверяваме дали е натиснат клавиш Escape.
        {
            SceneManager.LoadScene(menuScene); // Променяме сцената на menuScene.
        }

        if (antigrav == false) // Проверяваме дали antigrav е със стойност false.
        {
            if (Physics.Raycast(transform.position, Vector3.down, 1f)) // Излъчваме лъч надолу от героя, който да проверява дали има обект отдолу.
        {
            // Променяме стойността на canJump на true.
            canJump = true;
        }
        else // Проверяваме дали горното условие не е спазено
        {
            // Променяме стойността на canJump на false.
            canJump = false;
        }
        }
          else if (antigrav) // Проверяваме дали antigrav е със стойност true.
        {
            if (Physics.Raycast(transform.position, Vector3.up, 1f)) // Излъчваме лъч нагоре от героя, който да проверява дали има обект отгоре.
            {
                // Променяме стойността на canJump2 на true.
                canJump2 = true;
            }
            else // Проверяваме дали горното условие не е спазено.
            {
                // Променяме стойността на canJump2 на false.
                canJump2 = false;
            }
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && canJump) // Проверяваме дали е натиснат клавиш Space и canJump е със стойност true.
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // Изтласкваме героя нагоре със силата зададена в променливата jumpForce.
        }

        if (Input.GetKeyDown(KeyCode.Space) && canJump2) // Проверяваме дали е натиснат клавиш Space и canJump2 е със стойност true.
        {
            rb.AddForce(Vector3.down * jumpForce, ForceMode.Impulse); // Изтласкваме героя надолу със силата зададена в променливата jumpForce.
        }

        if (Input.GetKeyDown(KeyCode.Q)) // Проверяваме дали е натиснат клавиш Q.
        {
            if (isLayer2) // Проверяваме дали isLayer2 е със стойност true.
            {
                this.transform.position = new Vector3(transform.position.x, transform.position.y, 0f); // Сменяме Z позицията на героя на 0.
                isLayer2 = false; // Променяме стойността на isLayer2 на false.
            }
            else // Проверяваме дали горното условие не е спазено.
            {
                this.transform.position = new Vector3(transform.position.x, transform.position.y, 9.3f); // Променяме Z позицията на героя на 9.3.
                isLayer2 = true; // Променяме стойността на isLayer2 на true.
            }
        }

        if (Input.GetKeyDown(KeyCode.E) && canAntigrav) // Проверяваме дали е натиснат клавиш E и стойността на canAntigrav е true.
        {
            antigrav = !antigrav; // Променяме стойността на antigrav на противоположната му стойност.
        }

        if (antigrav) // Проверяваме дали antigrav е със стойност true.
        {
            Physics.gravity = new Vector3(0, 9.81f, 0); // Променяме гравитацията така ,че да ни привлича нагоре.
        }
        else // Проверяваме дали горното условие не е спазено.
        {
            Physics.gravity = new Vector3(0, -9.81f, 0); // Променяме гравитацията така, че да ни привлича надолу.
        }
    }

    private void OnCollisionEnter(Collision collision) // Проверяваме дали героя се докосва до някой обект.
    {
        if (collision.gameObject.tag == "Coin") // Проверяваме дали обекта, до който се докосва героя е с таг "Coin".
        {
            this.transform.position = new Vector3(42, 1, 0); // Променяме позицията на героя на (41, 1, 0).
        }

        if (collision.gameObject.tag == "Coin2") // Проверяваме дали обекта, до който се докосва героя е с таг "Coin2".
        {
            this.transform.position = new Vector3(93, 1, 0); // Променяме позицията на героя на (93, 1, 0).
        }

        if (collision.gameObject.tag == "Coin3") // Проверяваме дали обекта, до който героя се докосва е с таг "Coin3".
        {
            this.transform.position = new Vector3(180, 1, 0); // Променяме позицията на героя на (180, 1, 0).
            camera.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, -20); // Променяме позицията на камерата така, че да е равна по X и Y на героя и с Z с 20 по-малък.
        }

        if (collision.gameObject.tag == "Coin4") // Проверяваме дали обекта, до който героя се е докоснал е с таг "Coin4".
        {
            this.transform.position = new Vector3(265, 1, 0); // Променяме позицията на героя на (265, 1, 0).
        }

        if (collision.gameObject.tag == "Kill") // Проверяваме дали обекта, до който се докосва героя е с таг "Kill".
        {
            this.transform.position = new Vector3(42, 1, 0); // Променяме позицията на героя на (42, 1, 0).
        }

        if (collision.gameObject.tag == "Kill2") // Проверяваме дали обекта, до който се докосва героя е с таг "Kill2".
        {
            this.transform.position = new Vector3(180, 1, 0); // Променяме позицията на героя на (180, 1, 0).
        }
    }

    private void OnTriggerEnter(Collider other) // Проверяваме дали героя е докоснал обект, който е trigger.
    {
        if (other.gameObject.tag == "Coin") // Проверяваме дали обекта, до който се е докоснал героя е с таг "Coin".
        {
            winnerText.SetActive(true); // Показваме текста за победа.
        }

        if (other.gameObject.tag == "Portal1") // Проверяваме дали обекта, до който се е докоснал героя е с таг "Portal1".
        {
            // Променяме позицията на героя да е сходна с тази на portal2.
            this.transform.position = new Vector3(portal2.transform.position.x + 1.5f, portal2.transform.position.y, portal2.transform.position.z);
        }

        if (other.gameObject.tag == "Portal2") // Проверяваме дали обекта, до който се е докоснал е с таг "Portal2".
        {
            // Променяме позицията на героя да е сходна с тази на portal1.
            this.transform.position = new Vector3(portal1.transform.position.x + 1.5f, portal1.transform.position.y, portal1.transform.position.z);
            
        }

        if (other.gameObject.tag == "BluePortal1") // Проверяваме дали обекта, до който се е докоснал героя е с таг "BluePortal1".
        {
            // Променяме позицията на героя да е сходна с тази на bluePortal2.
            this.transform.position = new Vector3(bluePortal2.transform.position.x + 1.5f, bluePortal2.transform.position.y, bluePortal2.transform.position.z);
        }

        if (other.gameObject.tag == "BluePortal2") // Проверяваме дали обекта, до който се е докоснал героя е с таг "BluePortal2".
        {
            // Променяме позицията на героя да е сходна с тази на bluePortal1.
            this.transform.position = new Vector3(bluePortal1.transform.position.x + 1.5f, bluePortal1.transform.position.y, bluePortal1.transform.position.z);
        }

        if (other.gameObject.tag == "OrangePortal1") // Проверяваме дали обекта, до който се е докоснал героя е с таг "OrangePortal1".
        {
            // Променяме позицията на героя да е сходна с тази на orangePortal2.
            this.transform.position = new Vector3(orangePortal2.transform.position.x + 1.5f, orangePortal2.transform.position.y, orangePortal2.transform.position.z);
        }

        if (other.gameObject.tag == "OrangePortal2") // Проверяваме дали обекта, до който се е докоснал героя е с таг "OrangePortal2".
        {
            // Променяме позицията на героя да е сходна с тази на orangePortal1.
            this.transform.position = new Vector3(orangePortal1.transform.position.x + 1.5f, orangePortal1.transform.position.y, orangePortal1.transform.position.z);
        }
    }

    private void OnCollisionStay(Collision collision) // Проверяваме дали героя се докосва за продължително време с някой обект.
    {
        if (collision.gameObject.tag == "Climb" && Input.GetKey(KeyCode.Space)) // Проверяваме дали обекта, до който се докосва героя е с таг "Climb" и е натиснат клавиш Space.
        {
            // Променяме Y на героя с 0.1.
            this.transform.position = Vector3.Lerp(this.transform.position, new Vector3(this.transform.position.x, this.transform.position.y + 0.1f, this.transform.position.z), 100f);
        }
    }
}
