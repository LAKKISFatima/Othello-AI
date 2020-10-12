using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game : MonoBehaviour
    
{

    public Transform white_tokenObj;
    public Transform black_tokenObj;

    public Text Nb_White;
    public Text Nb_Black;

    public static String current_turn = "W";

    public static String[,] BOARD =new String [8,8];

    public static GameObject[,] objects = new GameObject[8, 8];

    public static void printBoard(String[,] bOARD)
    {
        String b = "";
        for(int i=0;i<8;i++)
        {
            for(int j=0;j<8;j++)
            {
                b = b+ bOARD[i, j] + " ";
            }
            b += "\n";
        }

        Debug.Log(b);
        Console.WriteLine(b);
    }

    public static int CountWhiteTokens(String[,] board)
    {
        int count=0;
        for (int i = 0; i < 8; i++)
            for (int j = 0; j < 8; j++)
                if (board[i, j] == "W")
                    count++;
        return count;
    }

    public static int CountBlackTokens(String[,] board)
    {
        int count = 0;
        for (int i = 0; i < 8; i++)
            for (int j = 0; j < 8; j++)
                if (board[i, j] == "B")
                    count++;
        return count;
    }

    public static int DiscsOnBoard(String[,] board)
    {
        int count = 0;
        for (int i = 0; i < 8; i++)
            for (int j = 0; j < 8; j++)
                if (board[i, j] != "E" )
                    count++;
        return count;
    }

    public static bool TerminalState(String[,] board)
    {
        if (DiscsOnBoard(board) == 64)
            return true;
        return false;
    }

    public void update_Scores()
    {
        Nb_White.text = "White Tokens : "+ CountWhiteTokens(BOARD);

        Nb_Black.text = "Black Tokens : " + CountBlackTokens(BOARD);
    }

    // Start is called before the first frame update
    void Start()
    {
        Transform tok;

        GameObject g = GameObject.Find("square(4,3)");
        tok =Instantiate(black_tokenObj, g.transform.position, black_tokenObj.rotation);
        g.transform.tag = "B";
        objects[4, 3] = tok.gameObject;
       

        g = GameObject.Find("square(3,4)");
        tok=Instantiate(black_tokenObj, g.transform.position, black_tokenObj.rotation);
        g.transform.tag = "B";
        objects[3, 4] = tok.gameObject;

        g = GameObject.Find("square(4,4)");
        tok=Instantiate(white_tokenObj, g.transform.position, white_tokenObj.rotation);
        g.transform.tag = "W";
        objects[4, 4] = tok.gameObject;

        g = GameObject.Find("square(3,3)");
        tok=Instantiate(white_tokenObj, g.transform.position, white_tokenObj.rotation);
        g.transform.tag = "W";
        objects[3, 3] = tok.gameObject;



        for (int i = 0; i <= 7; i++)
            for (int j = 0; j <= 7; j++)
                BOARD[i, j] = "E";

        BOARD[4,3] = "B";
        BOARD[3,4] = "B";

        BOARD[3,3] = "W";
        BOARD[4,4] = "W";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
