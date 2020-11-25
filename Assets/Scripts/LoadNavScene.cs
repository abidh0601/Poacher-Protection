using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadNavScene : MonoBehaviour
{
    public int instructionCount = 0;

    private Player_Input player_Input;

    public Text instructionText;
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
    string instruction2 = "Day:\n\tYou will be able to create fences \n\tWolves will reproduce and eat\n\tWolves need to eat in order to survive\n\nNight:\n\tRobots will spawn and try to eat the wolves\n\tYou can scare robots by looking at them\nEach consecutive night robots will become faster\n\nGame is over when there are no wolves left\nSurvive as many rounds as possible\n\n\tPress Triangle to Start";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player_Input.Player.PlaceFence.triggered)
        {
            if(instructionCount == 0)
            {
                instructionText.text = instruction2;
            }
            else
            {
                SceneManager.LoadScene("NavMeshScene");
            }
            instructionCount++;
        }
    }
}
