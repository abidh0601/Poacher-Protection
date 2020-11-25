using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.AI;
public class Display : MonoBehaviour
{

    public float currentTime;
    
    public Text nightMode;
    public Text deleteMode;
    public Text roundCounter;
    public Text gameOverRound;
    public Text wolfCounter;

    public GameObject player;
    public GameObject dayNight;
    public GameObject HUD;
    public GameObject gameOver;
    public GameObject wolfParent;
    public GameObject enemyPrefab;

    private Player_Input player_Input;

    private void Awake()
    {
        player_Input = new Player_Input();
    }

    private void OnEnable()
    {
        player_Input.Enable();
    }

    private void OnDisable()
    {
        player_Input.Disable();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(wolfParent.transform.childCount != 0)
        {
            bool deleteBool = player.transform.GetChild(0).GetComponent<CreateWall>().deleteMode;
            bool nightBool = dayNight.GetComponent<DayNight>().nightTime;
            float currentTime = dayNight.GetComponent<DayNight>().currentTime;


            if (deleteBool)
            {
                deleteMode.text = "Delete Mode: On";
            }
            else
            {
                deleteMode.text = "Delete Mode: Off";
            }

            if (nightBool)
            {
                nightMode.text = "Day in: " + currentTime.ToString("0");
            }
            else
            {
                nightMode.text = "Night in: " + currentTime.ToString("0");
            }

            roundCounter.text = "Round: " + dayNight.GetComponent<DayNight>().roundNumber.ToString("0");
            wolfCounter.text = "Wolves: " + wolfParent.transform.childCount.ToString() + "/" + wolfParent.GetComponent<BunnySpawner>().maxChild.ToString();
        }
        else
        {
            gameOverRound.text = roundCounter.text;

            HUD.SetActive(false);
            gameOver.SetActive(true);
            player.GetComponent<PlayerMovement>().enabled = false;
            player.GetComponent<PickupObject>().enabled = false;
            player.GetComponent<InteractObject>().enabled = false;

            if (player_Input.Player.PlaceFence.triggered)
            {
                enemyPrefab.GetComponent<NavMeshAgent>().speed = 2;
                SceneManager.LoadScene("NavMeshScene");
            }
        }
    }
        
}
