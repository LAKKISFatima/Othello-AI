using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickon : MonoBehaviour
{

    public Transform white_tokenObj;
    public Transform black_tokenObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InsertWhitePiece(int i, int j)
    {
        
        int x = i + 1,y =j+1 ;
        String[,] newBoard= new String[8, 8];
        Transform tok;

        for (int ii = 0; ii <= 7; ii++)
            for (int jj = 0; jj <= 7; jj++)
                newBoard[ii, jj] = game.BOARD[ii, jj];


        //to the right
        while (y<8)
        {
            if (game.BOARD[i, y] == "W" || game.BOARD[i, y] == "E")
                break;
            newBoard[i, y] = "T";
            y = y + 1;
        }
        if(y!=8)
 
        {
           
            if (newBoard[i, y] == "W")
            {
                Debug.Log("Should Change");
                int my = j + 1;
                while (my < 8)
                {
                  
                    if (game.BOARD[i, my] == "W" || game.BOARD[i, my] == "E")
                    {
                        break;
                    }
                    else{
                        if (newBoard[i, my] == "T")
                        {
                            game.BOARD[i, my] = "W";
                            newBoard[i, my] = "W";
                            String square = "square(" + i + "," + my + ")";
                            GameObject g = GameObject.Find(square);
                            g.tag = "W";

                            Destroy(game.objects[i,my]);
                            game.objects[i, my] = null;
                            tok =Instantiate(white_tokenObj, g.transform.position, white_tokenObj.rotation);

                            game.objects[i, my] = tok.gameObject;

                        }
                        my++;
                    }
       
                }
            }
        
        }


        //to the left
        y = j - 1;
        while (y >= 0)
        {
            if (game.BOARD[i, y] == "W" || game.BOARD[i, y] == "E")
                break;
            newBoard[i, y] = "T";
            y--; ;
        }
        if (y != -1)

        {
            if (newBoard[i, y] == "W")
            {
                Debug.Log("Should Change");
                int my = j - 1;
                while (my >=0)
                {
                    if (game.BOARD[i, my] == "W" || game.BOARD[i, my] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[i, my] == "T")
                        {
                            game.BOARD[i, my] = "W";
                            newBoard[i, my] = "W";
                            game.objects[i, my] = null;
                            String square = "square(" + i + "," + my + ")";

                            Destroy(game.objects[i, my]);
                            GameObject g = GameObject.Find(square);
                            
                            g.tag = "W";
                            tok=Instantiate(white_tokenObj, g.transform.position, white_tokenObj.rotation);
                            game.objects[i, my] = tok.gameObject;
                        }
                        my--;
                    }

                }
            }

        }

        x = i + 1;
        //to the bottom
        while (x < 8)
        {
            if (game.BOARD[x, j] == "W" || game.BOARD[x, j] == "E")
                break;
            newBoard[x, j] = "T";
            x = x + 1;
        }
        if (x != 8)

        {
            if (newBoard[x, j] == "W")
            {
                Debug.Log("Should Change");
                int mx = i + 1;
                while (mx < 8)
                {
                    if (game.BOARD[mx, j] == "W" || game.BOARD[mx,j] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[mx,j] == "T")
                        {
                            game.BOARD[mx, j] = "W";
                            newBoard[mx,j] = "W";
                            String square = "square(" + mx + "," + j + ")";
                            Destroy(game.objects[mx, j]);
                            GameObject g = GameObject.Find(square);
                            g.tag = "W";
                            tok= Instantiate(white_tokenObj, g.transform.position, white_tokenObj.rotation);
                            game.objects[mx, j] = tok.gameObject;
                        }
                        mx++;
                    }

                }
            }

        }
        x = i - 1;
        //to the top
        while (x >= 0)
        {
            if (game.BOARD[x, j] == "W" || game.BOARD[x, j] == "E")
                break;
            newBoard[x, j] = "T";
            x--; ;
        }
        if (x != -1)

        {
            if (newBoard[x, j] == "W")
            {
                Debug.Log("Should Change");
                int mx = i - 1;
                while (mx >=0)
                {
                    if (game.BOARD[mx, j] == "W" || game.BOARD[mx, j] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[mx, j] == "T")
                        {
                            game.BOARD[mx, j] = "W";
                            newBoard[mx, j] = "W";
                            String square = "square(" + mx + "," + j + ")";
                            Destroy(game.objects[mx, j]);
                            GameObject g = GameObject.Find(square);
                            g.tag = "W";
                            tok= Instantiate(white_tokenObj, g.transform.position, white_tokenObj.rotation);
                            game.objects[mx, j] = tok.gameObject;
                        }
                        mx--;
                    }

                }
            }

        }

        //diagonal right down
        x = i + 1;
        y = j + 1;
        while (x < 8 && y<8)
        {
            if (game.BOARD[x, y] == "W" || game.BOARD[x, y] == "E")
                break;
            newBoard[x, y] = "T";
            x++;
            y++;
 
        }
        if (x != 8 && y!=8)
        {
            if (newBoard[x, y] == "W")
            {
                Debug.Log("Should Change");
                int mx = i + 1;
                int my = j + 1;
                while (mx < 8 && my<8)
                {
                    if (game.BOARD[mx, my] == "W" || game.BOARD[mx, my] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[mx, my] == "T")
                        {
                            game.BOARD[mx, my] = "W";
                            newBoard[mx, my] = "W";
                            String square = "square(" + mx + "," + my + ")";
                            Destroy(game.objects[mx, my]);
                            GameObject g = GameObject.Find(square);
                            g.tag = "W";
                            tok= Instantiate(white_tokenObj, g.transform.position, white_tokenObj.rotation);
                            game.objects[mx, j] = tok.gameObject;

                        }
                        mx++;
                        my++;
   
                    }

                }
            }

        }

        //diagonal right up
        x = i - 1;
        y = j + 1;
        while (x >-1 && y < 8)
        {
            if (game.BOARD[x, y] == "W" || game.BOARD[x, y] == "E")
                break;
            newBoard[x, y] = "T";
            x--;
            y++;

        }
        if (x !=-1 && y != 8)
        {
            if (newBoard[x, y] == "W")
            {
                Debug.Log("Should Change");
                int mx = i - 1;
                int my = j + 1;
                while (mx < 8 && my < 8)
                {
                    if (game.BOARD[mx, my] == "W" || game.BOARD[mx, my] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[mx, my] == "T")
                        {
                            game.BOARD[mx, my] = "W";
                            newBoard[mx, my] = "W";
                            String square = "square(" + mx + "," + my + ")";
                            Destroy(game.objects[mx, my]);
                            GameObject g = GameObject.Find(square);
                            g.tag = "W";
                            tok= Instantiate(white_tokenObj, g.transform.position, white_tokenObj.rotation);
                            game.objects[mx, my] = tok.gameObject;
                        }
                        mx--;
                        my++;

                    }

                }
            }

        }

        //diagonal left up
        x = i - 1;
        y = j - 1;
        while (x > -1 && y >-1)
        {
            if (game.BOARD[x, y] == "W" || game.BOARD[x, y] == "E")
                break;
            newBoard[x, y] = "T";
            x--;
            y--;

        }
        if (x != -1 && y != -1)
        {
            if (newBoard[x, y] == "W")
            {
                Debug.Log("Should Change");
                int mx = i - 1;
                int my = j - 1;
                while (mx > -1 && my >-1)
                {
                    if (game.BOARD[mx, my] == "W" || game.BOARD[mx, my] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[mx, my] == "T")
                        {
                            game.BOARD[mx, my] = "W";
                            newBoard[mx, my] = "W";
                            String square = "square(" + mx + "," + my + ")";
                            Destroy(game.objects[mx, my]);
                             
                            GameObject g = GameObject.Find(square);
                            g.tag = "W";
                            tok=Instantiate(white_tokenObj, g.transform.position, white_tokenObj.rotation);
                            game.objects[mx, my] = tok.gameObject;
                        }
                        mx--;
                        my--;

                    }

                }
            }

        }

        //diagonal left down
        x = i + 1;
        y = j - 1;
        while (x < 8 && y > -1)
        {
            if (game.BOARD[x, y] == "W" || game.BOARD[x, y] == "E")
                break;
            newBoard[x, y] = "T";
            x++;
            y--;

        }
        if (x != 8 && y != -1)
        {
            if (newBoard[x, y] == "W")
            {
                Debug.Log("Should Change");
                int mx = i + 1;
                int my = j - 1;
                while (mx < 8 && my > -1)
                {
                    if (game.BOARD[mx, my] == "W" || game.BOARD[mx, my] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[mx, my] == "T")
                        {
                            game.BOARD[mx, my] = "W";
                            newBoard[mx, my] = "W";
                            String square = "square(" + mx + "," + my + ")";
                            Destroy(game.objects[mx, my]);
                            GameObject g = GameObject.Find(square);
                            g.tag = "W";
                            tok= Instantiate(white_tokenObj, g.transform.position, white_tokenObj.rotation);
                            game.objects[mx, my] = tok.gameObject;
                        }
                        mx++;
                        my--;

                    }

                }
            }

        }

    }

    public void  InsertBlackPiece(int i,int j)
    {
        int x = i + 1, y = j + 1;
        String[,] newBoard = new String[8, 8];
        Transform tok;


        for (int ii = 0; ii <= 7; ii++)
            for (int jj = 0; jj <= 7; jj++)
                newBoard[ii, jj] = game.BOARD[ii, jj];

        //to the right
        while (y < 8)
        {
            if (game.BOARD[i, y] == "B" || game.BOARD[i, y] == "E")
                break;
            newBoard[i, y] = "T";
            y = y + 1;
        }
        if (y != 8)
        {
            if (newBoard[i, y] == "B")
            {

                Debug.Log("Should Change");
                int my = j + 1;
                while (my < 8)
                {
                    if (game.BOARD[i, my] == "B" || game.BOARD[i, my] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[i, my] == "T")
                        {
                            game.BOARD[i, my] = "B";
                            newBoard[i, my] = "B";
                            String square = "square(" + i + "," + my + ")";
                            //String square = "square(0,0)";
                            Destroy(game.objects[i, my]);
                            GameObject g = GameObject.Find(square);
                            g.tag = "B";
                            
                            tok=Instantiate(black_tokenObj, g.transform.position, black_tokenObj.rotation);
                            game.objects[i, my] = tok.gameObject;
                        }
                        my++;
                    }

                }
            }

        }


        //to the left
        y = j - 1;
        while (y >= 0)
        {
            if (game.BOARD[i, y] == "B" || game.BOARD[i, y] == "E")
                break;
            newBoard[i, y] = "T";
            y--; ;
        }
        if (y != -1)

        {
            if (newBoard[i, y] == "B")
            {
                Debug.Log("Should Change");
                int my = j - 1;
                while (my > -1)
                {
                    if (game.BOARD[i, my] == "B" || game.BOARD[i, my] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[i, my] == "T")
                        {
                            game.BOARD[i, my] = "B";
                            newBoard[i, my] = "B";
                            String square = "square(" + i + "," + my + ")";
                            Destroy(game.objects[i, my]);
                            GameObject g = GameObject.Find(square);
                            g.tag = "B";
                            tok= Instantiate(black_tokenObj, g.transform.position, black_tokenObj.rotation);
                            game.objects[i, my] = tok.gameObject;
                        }
                        my--;
                    }

                }
            }

        }

        x = i + 1;
        //to the bottom
        while (x < 8)
        {
            if (game.BOARD[x, j] == "B" || game.BOARD[x, j] == "E")
                break;
            newBoard[x, j] = "T";
            x = x + 1;
        }
        if (x != 8)

        {
            if (newBoard[x, j] == "B")
            {
                int mx = i + 1;
                Debug.Log("Should Change");
                while (mx < 8)
                {
                    if (game.BOARD[mx, j] == "B" || game.BOARD[mx, j] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[mx, j] == "T")
                        {
                            game.BOARD[mx, j] = "B";
                            newBoard[mx, j] = "B";
                            String square = "square(" + mx + "," + j + ")";
                            Destroy(game.objects[mx, j]);
                            GameObject g = GameObject.Find(square);
                            g.tag = "B";
                            tok=Instantiate(black_tokenObj, g.transform.position, black_tokenObj.rotation);
                            game.objects[mx, j] = tok.gameObject;
                        }
                        mx++;
                    }

                }
            }

        }

        x = i - 1;
        //to the top
        while (x >= 0)
        {
            if (game.BOARD[x, j] == "B" || game.BOARD[x, j] == "E")
                break;
            newBoard[x, j] = "T";
            x--; ;
        }
        if (x != -1)

        {
            if (newBoard[x, j] == "B")
            {
                int mx = i - 1;
                Debug.Log("Should Change");
                while (mx > -1)
                {
                    if (game.BOARD[mx, j] == "B" || game.BOARD[mx, j] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[mx, j] == "T")
                        {
                            game.BOARD[mx, j] = "B";
                            newBoard[mx, j] = "B";
                            String square = "square(" + mx + "," + j + ")";
                            Destroy(game.objects[mx, j]);
                            GameObject g = GameObject.Find(square);
                            g.tag = "B";
                            tok= Instantiate(black_tokenObj, g.transform.position, black_tokenObj.rotation);
                            game.objects[mx, j] = tok.gameObject;
                        }
                        mx--;
                    }

                }
            }

        }

        //diagonal right down
        x = i + 1;
        y = j + 1;
        while (x < 8 && y < 8)
        {
            if (game.BOARD[x, y] == "B" || game.BOARD[x, y] == "E")
                break;
            newBoard[x, y] = "T";
            x++;
            y++;

        }
        if (x != 8 && y != 8)
        {
            if (newBoard[x, y] == "B")
            {
                Debug.Log("Should Change");
                int mx = i + 1;
                int my = j + 1;
                while (mx < 8 && my < 8)
                {
                    if (game.BOARD[mx, my] == "B" || game.BOARD[mx, my] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[mx, my] == "T")
                        {
                            game.BOARD[mx, my] = "B";
                            newBoard[mx, my] = "B";
                            String square = "square(" + mx + "," + my + ")";
                            Destroy(game.objects[mx, my]);
                            GameObject g = GameObject.Find(square);
                            g.tag = "B";
                            tok=Instantiate(black_tokenObj, g.transform.position, black_tokenObj.rotation);
                            game.objects[mx, my] = tok.gameObject;
                        }
                        mx++;
                        my++;

                    }

                }
            }

        }

        //diagonal right up
        x = i - 1;
        y = j + 1;
        while (x > -1 && y < 8)
        {
            if (game.BOARD[x, y] == "B" || game.BOARD[x, y] == "E")
                break;
            newBoard[x, y] = "T";
            x--;
            y++;

        }
        if (x != -1 && y != 8)
        {
            if (newBoard[x, y] == "B")
            {
                Debug.Log("Should Change");
                int mx = i - 1;
                int my = j + 1;
                while (mx < 8 && my < 8)
                {
                    if (game.BOARD[mx, my] == "B" || game.BOARD[mx, my] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[mx, my] == "T")
                        {
                            game.BOARD[mx, my] = "B";
                            newBoard[mx, my] = "B";
                            String square = "square(" + mx + "," + my + ")";
                            Destroy(game.objects[mx, my]);
                            GameObject g = GameObject.Find(square);
                            g.tag = "B";
                            tok=Instantiate(black_tokenObj, g.transform.position, black_tokenObj.rotation);
                            game.objects[mx, my] = tok.gameObject;
                        }
                        mx--;
                        my++;

                    }

                }
            }

        }

        //diagonal left up
        x = i - 1;
        y = j - 1;
        while (x > -1 && y > -1)
        {
            if (game.BOARD[x, y] == "B" || game.BOARD[x, y] == "E")
                break;
            newBoard[x, y] = "T";
            x--;
            y--;

        }
        if (x != -1 && y != -1)
        {
            if (newBoard[x, y] == "B")
            {
                Debug.Log("Should Change");
                int mx = i - 1;
                int my = j - 1;
                while (mx > -1 && my > -1)
                {
                    if (game.BOARD[mx, my] == "B" || game.BOARD[mx, my] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[mx, my] == "T")
                        {
                            game.BOARD[mx, my] = "B";
                            newBoard[mx, my] = "B";
                            String square = "square(" + mx + "," + my + ")";
                            Destroy(game.objects[mx, my]);
                            GameObject g = GameObject.Find(square);
                            g.tag = "B";
                            tok=Instantiate(black_tokenObj, g.transform.position, black_tokenObj.rotation);
                            game.objects[mx, my] = tok.gameObject;
                        }
                        mx--;
                        my--;

                    }

                }
            }

        }

        //diagonal left down
        x = i + 1;
        y = j - 1;
        while (x < 8 && y > -1)
        {
            if (game.BOARD[x, y] == "B" || game.BOARD[x, y] == "E")
                break;
            newBoard[x, y] = "T";
            x++;
            y--;

        }
        if (x != 8 && y != -1)
        {
            if (newBoard[x, y] == "B")
            {
                Debug.Log("Should Change");
                int mx = i + 1;
                int my = j - 1;
                while (mx < 8 && my > -1)
                {
                    if (game.BOARD[mx, my] == "B" || game.BOARD[mx, my] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[mx, my] == "T")
                        {
                            game.BOARD[mx, my] = "B";
                            newBoard[mx, my] = "B";
                            String square = "square(" + mx + "," + my + ")";
                            Destroy(game.objects[mx, my]);
                            GameObject g = GameObject.Find(square);
                            g.tag = "B";
                            tok=Instantiate(black_tokenObj, g.transform.position, black_tokenObj.rotation);
                            game.objects[mx, my] = tok.gameObject;
                        }
                        mx++;
                        my--;

                    }

                }
            }

        }
    }

    public String[,] InsertWhitePiece_Board(int i, int j, String[,] BOARD)
    {
        int x = i + 1, y = j + 1;
        String[,] newBoard = new String[8, 8];
        String[,] newBoard2 = new String[8, 8];

        for (int ii = 0; ii <= 7; ii++)
            for (int jj = 0; jj <= 7; jj++)
            {
                newBoard[ii, jj] = BOARD[ii, jj];
                newBoard2[ii, jj] = BOARD[ii, jj];
            }

        //to the right
        while (y < 8)
        {
            if (BOARD[i, y] == "W" || BOARD[i, y] == "E")
                break;
            newBoard[i, y] = "T";
            y = y + 1;
        }
        if (y != 8)
        {
            if (newBoard[i, y] == "W")
            {
                int my = j + 1;
                while (my < 8)
                {
                    if (BOARD[i, my] == "W" || BOARD[i, my] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[i, my] == "T")
                        {
                            newBoard[i, my] = "W";
                        }
                        my++;
                    }

                }
            }

        }


        //to the left
        y = j - 1;
        while (y >= 0)
        {
            if (BOARD[i, y] == "W" || BOARD[i, y] == "E")
                break;
            newBoard[i, y] = "T";
            y--; ;
        }
        if (y != -1)

        {
            if (newBoard[i, y] == "W")
            {
                int my = j - 1;
                while (my > -1)
                {
                    if (BOARD[i, my] == "W" || BOARD[i, my] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[i, my] == "T")
                        {
                            newBoard2[i, my] = "W";
                        }
                        my--;
                    }

                }
            }

        }

        x = i + 1;
        //to the bottom
        while (x < 8)
        {
            if (BOARD[x, j] == "W" || BOARD[x, j] == "E")
                break;
            newBoard[x, j] = "T";
            x = x + 1;
        }
        if (x != 8)

        {
            if (newBoard[x, j] == "W")
            {
                int mx = i + 1;
                while (mx < 8)
                {
                    if (BOARD[mx, j] == "W" || BOARD[mx, j] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[mx, j] == "T")
                        {
                            newBoard2[mx, j] = "W";
                        }
                        mx++;
                    }

                }
            }

        }

        x = i - 1;
        //to the top
        while (x >= 0)
        {
            if (BOARD[x, j] == "W" || BOARD[x, j] == "E")
                break;
            newBoard[x, j] = "T";
            x--; ;
        }
        if (x != -1)

        {
            if (newBoard[x, j] == "W")
            {
                int mx = i - 1;
                while (mx > -1)
                {
                    if (game.BOARD[mx, j] == "W" || game.BOARD[mx, j] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[mx, j] == "T")
                        {
                            newBoard2[mx, j] = "W";

                        }
                        mx--;
                    }

                }
            }

        }

        //diagonal right down
        x = i + 1;
        y = j + 1;
        while (x < 8 && y < 8)
        {
            if (BOARD[x, y] == "W" || BOARD[x, y] == "E")
                break;
            newBoard[x, y] = "T";
            x++;
            y++;

        }
        if (x != 8 && y != 8)
        {
            if (newBoard[x, y] == "W")
            {
                int mx = i + 1;
                int my = j + 1;
                while (mx < 8 && my < 8)
                {
                    if (BOARD[mx, my] == "W" || BOARD[mx, my] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[mx, my] == "T")
                        {
                            newBoard2[mx, my] = "W";

                        }
                        mx++;
                        my++;

                    }

                }
            }

        }

        //diagonal right up
        x = i - 1;
        y = j + 1;
        while (x > -1 && y < 8)
        {
            if (BOARD[x, y] == "W" || BOARD[x, y] == "E")
                break;
            newBoard[x, y] = "T";
            x--;
            y++;

        }
        if (x != -1 && y != 8)
        {
            if (newBoard[x, y] == "W")
            {
                int mx = i - 1;
                int my = j + 1;
                while (mx < 8 && my < 8)
                {
                    if (BOARD[mx, my] == "W" || BOARD[mx, my] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[mx, my] == "T")
                        {
                            newBoard2[mx, my] = "W";
                        }
                        mx--;
                        my++;

                    }

                }
            }

        }

        //diagonal left up
        x = i - 1;
        y = j - 1;
        while (x > -1 && y > -1)
        {
            if (BOARD[x, y] == "W" || BOARD[x, y] == "E")
                break;
            newBoard[x, y] = "T";
            x--;
            y--;

        }
        if (x != -1 && y != -1)
        {
            if (newBoard[x, y] == "W")
            {
                int mx = i - 1;
                int my = j - 1;
                while (mx > -1 && my > -1)
                {
                    if (BOARD[mx, my] == "W" || BOARD[mx, my] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[mx, my] == "T")
                        {
                            newBoard2[mx, my] = "W";
                        }
                        mx--;
                        my--;

                    }

                }
            }

        }

        //diagonal left down
        x = i + 1;
        y = j - 1;
        while (x < 8 && y > -1)
        {
            if (BOARD[x, y] == "W" || BOARD[x, y] == "E")
                break;
            newBoard[x, y] = "T";
            x++;
            y--;

        }
        if (x != 8 && y != -1)
        {
            if (newBoard[x, y] == "W")
            {
                int mx = i + 1;
                int my = j - 1;
                while (mx < 8 && my > -1)
                {
                    if (BOARD[mx, my] == "W" || BOARD[mx, my] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[mx, my] == "T")
                        {
                            newBoard2[mx, my] = "W";
                        }
                        mx++;
                        my--;

                    }

                }
            }

        }

        return newBoard2;
    }

    public String[,] InsertBlackPiece_Board(int i, int j,String[,] BOARD)
    {
        int x = i + 1, y = j + 1;
        String[,] newBoard = new String[8, 8];
        String[,] newBoard2 = new String[8, 8];

        for (int ii = 0; ii <= 7; ii++)
            for (int jj = 0; jj <= 7; jj++)
            {
                newBoard[ii, jj] = BOARD[ii, jj];
                newBoard2[ii, jj] = BOARD[ii, jj];
            }

        //to the right
        while (y < 8)
        {
            if (BOARD[i, y] == "B" || BOARD[i, y] == "E")
                break;
            newBoard[i, y] = "T";
            y = y + 1;
        }
        if (y != 8)
        {
            if (newBoard[i, y] == "B")
            {
                int my = j + 1;
                while (my < 8)
                {
                    if (BOARD[i, my] == "B" || BOARD[i, my] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[i, my] == "T")
                        {
                            newBoard2[i, my] = "B";
                        }
                        my++;
                    }

                }
            }

        }


        //to the left
        y = j - 1;
        while (y >= 0)
        {
            if (BOARD[i, y] == "B" || BOARD[i, y] == "E")
                break;
            newBoard[i, y] = "T";
            y--; ;
        }
        if (y != -1)

        {
            if (newBoard[i, y] == "B")
            {
                int my = j - 1;
                while (my > -1)
                {
                    if (BOARD[i, my] == "B" || BOARD[i, my] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[i, my] == "T")
                        {
                            newBoard2[i, my] = "B"; 
                        }
                        my--;
                    }

                }
            }

        }

        x = i + 1;
        //to the bottom
        while (x < 8)
        {
            if (BOARD[x, j] == "B" || BOARD[x, j] == "E")
                break;
            newBoard[x, j] = "T";
            x = x + 1;
        }
        if (x != 8)

        {
            if (newBoard[x, j] == "B")
            {
                int mx = i + 1;
                while (mx < 8)
                {
                    if (BOARD[mx, j] == "B" || BOARD[mx, j] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[mx, j] == "T")
                        {
                            newBoard2[mx, j] = "B";
                        }
                        mx++;
                    }

                }
            }

        }

        x = i - 1;
        //to the top
        while (x >= 0)
        {
            if (BOARD[x, j] == "B" || BOARD[x, j] == "E")
                break;
            newBoard[x, j] = "T";
            x--; ;
        }
        if (x != -1)

        {
            if (newBoard[x, j] == "B")
            {
                int mx = i - 1;
                while (mx > -1)
                {
                    if (game.BOARD[mx, j] == "B" || game.BOARD[mx, j] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[mx, j] == "T")
                        {
                            newBoard2[mx, j] = "B";
  
                        }
                        mx--;
                    }

                }
            }

        }

        //diagonal right down
        x = i + 1;
        y = j + 1;
        while (x < 8 && y < 8)
        {
            if (BOARD[x, y] == "B" || BOARD[x, y] == "E")
                break;
            newBoard[x, y] = "T";
            x++;
            y++;

        }
        if (x != 8 && y != 8)
        {
            if (newBoard[x, y] == "B")
            {
                int mx = i + 1;
                int my = j + 1;
                while (mx < 8 && my < 8)
                {
                    if (BOARD[mx, my] == "B" || BOARD[mx, my] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[mx, my] == "T")
                        {
                            newBoard2[mx, my] = "B";

                        }
                        mx++;
                        my++;

                    }

                }
            }

        }

        //diagonal right up
        x = i - 1;
        y = j + 1;
        while (x > -1 && y < 8)
        {
            if (BOARD[x, y] == "B" || BOARD[x, y] == "E")
                break;
            newBoard[x, y] = "T";
            x--;
            y++;

        }
        if (x != -1 && y != 8)
        {
            if (newBoard[x, y] == "B")
            {
                int mx = i - 1;
                int my = j + 1;
                while (mx < 8 && my < 8)
                {
                    if (BOARD[mx, my] == "B" || BOARD[mx, my] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[mx, my] == "T")
                        {
                            newBoard2[mx, my] = "B";
                        }
                        mx--;
                        my++;

                    }

                }
            }

        }

        //diagonal left up
        x = i - 1;
        y = j - 1;
        while (x > -1 && y > -1)
        {
            if (BOARD[x, y] == "B" || BOARD[x, y] == "E")
                break;
            newBoard[x, y] = "T";
            x--;
            y--;

        }
        if (x != -1 && y != -1)
        {
            if (newBoard[x, y] == "B")
            {
                int mx = i - 1;
                int my = j - 1;
                while (mx > -1 && my > -1)
                {
                    if (BOARD[mx, my] == "B" || BOARD[mx, my] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[mx, my] == "T")
                        {
                            newBoard2[mx, my] = "B";
                        }
                        mx--;
                        my--;

                    }

                }
            }

        }

        //diagonal left down
        x = i + 1;
        y = j - 1;
        while (x < 8 && y > -1)
        {
            if (BOARD[x, y] == "B" || BOARD[x, y] == "E")
                break;
            newBoard[x, y] = "T";
            x++;
            y--;

        }
        if (x != 8 && y != -1)
        {
            if (newBoard[x, y] == "B")
            {
                int mx = i + 1;
                int my = j - 1;
                while (mx < 8 && my > -1)
                {
                    if (BOARD[mx, my] == "B" || BOARD[mx, my] == "E")
                    {
                        break;
                    }
                    else
                    {
                        if (newBoard[mx, my] == "T")
                        {
                            newBoard2[mx, my] = "B";
                        }
                        mx++;
                        my--;

                    }

                }
            }

        }

        return newBoard2;
    }

    private void OnMouseDown()
    {

        int i, j;
        String name = transform.name;
        string[] w1 = name.Split('(');
        string []w2=w1[1].Split(',');
        string[] w3 = w2[1].Split(')');
        i = Int32.Parse(w2[0]);
        j = Int32.Parse(w3[0]);
    
        Debug.Log("CLicked on : "+i+ " "+j);

        Transform tok;
        if (game.current_turn == "W")
        {
            tok=Instantiate(white_tokenObj, transform.position, white_tokenObj.rotation);
            game.objects[i, j] = tok.gameObject;
            game.current_turn = "B";
            game.BOARD[i, j] = "W";
            transform.tag = "W";
            GetComponent<BoxCollider2D>().enabled = false;
            InsertWhitePiece(i, j);

           // String[,] board = game.BOARD;
           // Move m = getBestMove(board, 3, "B");
           // String square = "square(" + m.i + "," + m.j + ")";
           // GameObject g = GameObject.Find(square);
           // tok = Instantiate(black_tokenObj, g.transform.position, black_tokenObj.rotation);
           // game.objects[m.i, m.j] = tok.gameObject;
           // g.transform.tag = "B";
           //// game.current_turn = "W";
           // game.BOARD[m.i, m.j] = "B";
           // InsertBlackPiece(m.i, m.j);
        }

        else if (game.current_turn == "B")
        {
        //    //tok = Instantiate(black_tokenObj, transform.position, black_tokenObj.rotation);
        //    //game.objects[i, j] = tok.gameObject;
        //    //game.current_turn = "W";
        //    //game.BOARD[i, j] = "B";
        //    //transform.tag = "B";
        //    //GetComponent<BoxCollider2D>().enabled = false;
        //    //InsertBlackPiece(i, j);

        String[,] board = game.BOARD;
        Move m = getBestMove(board, 5, "B");
        String square = "square(" + m.i + "," + m.j + ")";
        GameObject g = GameObject.Find(square);
        tok = Instantiate(black_tokenObj, g.transform.position, black_tokenObj.rotation);
        game.objects[m.i, m.j] = tok.gameObject;
        g.transform.tag = "B";
        game.current_turn = "W";
        game.BOARD[m.i, m.j] = "B";
        InsertBlackPiece(m.i, m.j);

        }
    }

    public  int CountWhiteTokens(String[,] board)
    {
        int count = 0;
        for (int i = 0; i < 8; i++)
            for (int j = 0; j < 8; j++)
                if (board[i, j] == "W")
                    count++;
        return count;
    }

    public  int CountBlackTokens(String[,] board)
    {
        int count = 0;
        for (int i = 0; i < 8; i++)
            for (int j = 0; j < 8; j++)
                if (board[i, j] == "B")
                    count++;
        return count;
    }
    //missing potential mobility
    public float Evaluate(String[,] board, String color)
    {
        if (game.TerminalState(board) == true)
        {
            return 100000 * utility(board, color);
        }

        if (game.DiscsOnBoard(board) <= 20)
        {
            // Opening game
            return 5 * mobility(board, color)
                + 20 * squareWeights(board, color)
                + 10000 * Corners(board, color)
                + 10000 * stability(board, color);
        }
        else if (game.DiscsOnBoard(board) <= 58)
        {
            // Midgame
            return 10 * DiscDifference(board, color)
                + 2 * mobility(board, color)
                + 10 * squareWeights(board, color)
                + 100 * parity(board)
                + 10000 * Corners(board, color)
                + 10000 * stability(board, color);
        }
        else
        {
            // Endgame
            return 500 * DiscDifference(board, color)
                + 500 * parity(board)
                + 10000 * Corners(board, color)
                + 10000 * stability(board, color);
        }
    }

    // Relative disc difference between the two players
    public float DiscDifference(String[,] board,String color)
    {
        int blackCount = CountBlackTokens(board);
        int whiteCount = CountWhiteTokens(board);

        if (color == "W")
        {
            return 100 * (blackCount - whiteCount) / (blackCount + whiteCount);
        }
        else
        {
            return 100 * (whiteCount - blackCount) / (blackCount + whiteCount);
        }
    }

    public float Corners(String[,] board, String color)
    {
        int blackCorners = 0;
        int whiteCorners = 0;

        if (board[0, 0] == "W")
            whiteCorners++;
        else if (board[0, 0] == "B")
            blackCorners++;

        if (board[0, 7] == "W")
            whiteCorners++;
        else if (board[0, 7] == "B")
            blackCorners++;

        if (board[7, 0] == "W")
            whiteCorners++;
        else if (board[7, 0] == "B")
            blackCorners++;

        if (board[7, 7] == "W")
            whiteCorners++;
        else if (board[7, 7] == "B")
            blackCorners++;

        if (color == "B")
        {
            return 100 * (blackCorners - whiteCorners)
                / (blackCorners + whiteCorners + 1);
        }
        else
        {
            return 100 * (whiteCorners - blackCorners)
                / (blackCorners + whiteCorners + 1);
        }
    }

    public int parity(String[,] board)
    {
            int squaresRemaining = 64 - game.DiscsOnBoard(board);

        //Heuristic Value =
        //100 * (Max Player Coins –Min Player Coins)/
        //        (Max Player Coins +Min Player Coins) 

            if (squaresRemaining % 2 == 0)
            {
                return -1;
            }
            else
            {
                return 1;
            }
    }

    public int utilCalculation(String[,] board)
    {
        int util = 0;
        for (int i = 0; i < 8; i++)
            for (int j = 0; j < 8; j++)
                if (board[i, j] == "B")
                    util++;
                else { util--; }
        return util;
    }

    public int utility(String[,] board,String color)
    {

        int util=0;
        util = utilCalculation(board);

        if (color == "B")
        {
            return util;
        }
        else
        {
            return -1 * util;
        }
    }

    public float mobility(String[,] board, String color)
    {
        List<Move> black_moves = findlegalMovesCount(board, "B");
        int bm = black_moves.Count;
        List<Move> white_moves = findlegalMovesCount(board, "W");
        int wm = white_moves.Count;

        if (color == "B")
        {
            return 100 * (bm - wm) / (bm + wm + 1);
        }
        else
        {
            return 100 * (wm - bm) / (bm + wm + 1);
        }
    }

    // Computes a lower bound on the number of stable discs
    public int stability(String[,] board,String color)
    {
        stableDiscs.Clear();

        stableDiscsFromCorner(board, 0, color);
        stableDiscsFromCorner(board, 7, color);
        stableDiscsFromCorner(board, 56, color);
        stableDiscsFromCorner(board, 63, color);

        int myStables = stableDiscs.Count;
        if (color == "W")
            color = "B";

        else color = "W";
        stableDiscsFromCorner(board, 0, color);
        stableDiscsFromCorner(board, 7, color);
        stableDiscsFromCorner(board, 56, color);
        stableDiscsFromCorner(board, 63, color);

        int opponentStables = stableDiscs.Count;

        return myStables - opponentStables;
    }

    public static HashSet<int> stableDiscs = new HashSet<int>();

    public void stableDiscsFromCorner(String[,] b, int corner,String color)
    {
        bool down, right;
        if (corner == 0)
        {
            down = true;
            right = true;
        }
        else if (corner == 7)
        {
            down = true;
            right = false;
        }
        else if (corner == 56)
        {
            down = false;
            right = true;
        }
        else
        {
            down = false;
            right = false;
        }

        int horizIncr = 1, horizStop = 7, vertIncr = 8, vertStop = 56;

        if (!right)
        {
            horizIncr *= -1;
            horizStop *= -1;
        }
        if (!down)
        {
            vertIncr *= -1;
            vertStop *= -1;
        }

        String[] board = flatBoard2(b);

        // Iterate horizontally
        for (int i = corner; i != corner + horizIncr + horizStop; i += horizIncr)
        {
            // If there is a disc of our color on this square
            if (board[i] == color)
            {
                // Iterate vertically
                for (int j = i; j != i + vertStop; j += vertIncr)
                {
                    // If there is a disc of our color on this square,
                    // and it is not in the set of stable discs

              
                    if (board[j] == color && !stableDiscs.Contains(j))
                    {
                        // Insert it to the set
                        stableDiscs.Add(j);
                    }
                    // If we come across a disc of the opposite color, break
                    else
                    {
                        break;
                    }
                }
            }
            // Otherwise, break
            else
            {
                break;
            }
        }
    }

    // Assigns a weight to every square on the board
    public float squareWeights(String[,] board,String color)
    {
        int[] weights={
         200, -100, 100,  50,  50, 100, -100,  200,
        -100, -200, -50, -50, -50, -50, -200, -100,
         100,  -50, 100,   0,   0, 100,  -50,  100,
          50,  -50,   0,   0,   0,   0,  -50,   50,
          50,  -50,   0,   0,   0,   0,  -50,   50,
         100,  -50, 100,   0,   0, 100,  -50,  100,
        -100, -200, -50, -50, -50, -50, -200, -100,
         200, -100, 100,  50,  50, 100, -100,  200,
    };
        if (board[0,0] != "E")
        {
            weights[1] = 0;
            weights[2] = 0;
            weights[3] = 0;
            weights[8] = 0;
            weights[9] = 0;
            weights[10] = 0;
            weights[11] = 0;
            weights[16] = 0;
            weights[17] = 0;
            weights[18] = 0;
            weights[24] = 0;
            weights[25] = 0;
        }

        if (board[0,7] != "E")
        {
            weights[4] = 0;
            weights[5] = 0;
            weights[6] = 0;
            weights[12] = 0;
            weights[13] = 0;
            weights[14] = 0;
            weights[15] = 0;
            weights[21] = 0;
            weights[22] = 0;
            weights[23] = 0;
            weights[30] = 0;
            weights[31] = 0;
        }

        if (board[7,0] != "E")
        {
            weights[32] = 0;
            weights[33] = 0;
            weights[40] = 0;
            weights[41] = 0;
            weights[42] = 0;
            weights[48] = 0;
            weights[49] = 0;
            weights[50] = 0;
            weights[51] = 0;
            weights[57] = 0;
            weights[58] = 0;
            weights[59] = 0;
        }

        if (board[7,7] != "E")
        {
            weights[38] = 0;
            weights[39] = 0;
            weights[45] = 0;
            weights[46] = 0;
            weights[47] = 0;
            weights[52] = 0;
            weights[53] = 0;
            weights[54] = 0;
            weights[55] = 0;
            weights[60] = 0;
            weights[61] = 0;
            weights[62] = 0;
        }
        if (color == "B")
        {
            return InnerProduct(flatBoard(board), weights); ;
        }
        else
        {
            return -1 * InnerProduct(flatBoard(board),weights); ;
        }
    }

    public int InnerProduct(int[] board1,int[] board2)
    {
        int product = 0;
        for (int i = 0; i < board1.Length; i++)
            product += board1[i] * board2[i];

        return product;

    }

    public int[] flatBoard(String[,] board)
    {
        int[] flatten = new int[64];
        int count = 0;
        for (int i = 0; i < 8; i++)
            for (int j = 0; j < 8; j++)
                if (board[i, j] == "B")
                    flatten[count] = 1;
                else if (board[i, j] == "W")
                    flatten[count] = -1;
                else flatten[count] = 0;

        return flatten;
    }

    public String[] flatBoard2(String[,] board)
    {
        String[] flatten = new String[64];
        int count = 0;
        for (int i = 0; i < 8; i++)
            for (int j = 0; j < 8; j++)
                flatten[count] = board[i, j];

        return flatten;
    }

    public List<Move> Remove_Duplication(List<Move> moves)
    {
        List<Move> list = moves;

        for (int i = 0; i < moves.Count; i++)
            for (int j = i + 1; j < moves.Count; j++)
                if (moves[i].i == moves[j].i && moves[i].j == moves[j].j)
                {
                    moves.Remove(moves[j]);
                }
        return moves;
    }

    public List<Move> findlegalMovesCount(String[,] B, String turn)
    {

        List<Move> al = new List<Move>();
        for (int i = 0; i < 8; i++)
            for (int j = 0; j < 8; j++)
            {

                if (B[i, j] == turn)
                {//to right
                    int ii = i, jj = j + 1;
                    while (jj < 8)
                    {
                        if (B[i, jj] == turn || B[i, jj] == "E")
                            break;
                        jj++;
                    }
                    if (jj < 8 && B[i, jj] == "E" && jj!=j+1)
                    {
                        Move m = new Move();
                        m.i = i; m.j = jj;
                        al.Add(m);

                    }


                    //to left
                    ii = i; jj = j - 1;
                    while (jj >= 0)
                    {
                        if (B[i, jj] == turn || B[i, jj] == "E")
                            break;
                        jj--;
                    }
                    if (jj >= 0 && B[i, jj] == "E" && jj!= j-1)
                    {
                        Move m = new Move();
                        m.i = i; m.j = jj;
                        al.Add(m);

                    }

                    //to up
                    ii = i - 1; jj = j;
                    while (ii >= 0)
                    {
                        if (B[ii, j] == turn || B[ii, j] == "E")
                            break;
                        ii--;
                    }
                    if (ii >= 0 && B[ii, j] == "E" && ii != i-1)
                    {
                        Move m = new Move();
                        m.i = ii; m.j = j;
                        al.Add(m);

                    }

                    //to down
                    ii = i + 1; jj = j;
                    while (ii < 8)
                    {
                        if (B[ii, j] == turn || B[ii, j] == "E")
                            break;
                        ii++;
                    }
                    if (ii < 8 && B[ii, j] == "E" && ii != i+1)
                    {
                        Move m = new Move();
                        m.i = ii; m.j = j;
                        al.Add(m);

                    }

                    //to up-right
                    ii = i - 1; jj = j + 1;
                    while (ii >= 0 && jj < 8)
                    {
                        if (B[ii, jj] == turn || B[ii, jj] == "E")
                            break;
                        ii--; jj++;
                    }
                    if (ii >= 0 && jj < 8 && B[ii, jj] == "E" && ii!=i-1 && jj!=j+1)
                    {
                        Move m = new Move();
                        m.i = ii; m.j = jj;
                        al.Add(m);

                    }

                    //to up-left
                    ii = i - 1; jj = j - 1;
                    while (ii >= 0 && jj >= 0)
                    {
                        if (B[ii, jj] == turn || B[ii, jj] == "E")
                            break;
                        ii--; jj--;
                    }
                    if (ii >= 0 && jj >= 0 && B[ii, jj] == "E" && ii!=i-1 && jj!=j-1)
                    {
                        Move m = new Move();
                        m.i = ii; m.j = jj;
                        al.Add(m);

                    }

                    //to down-left
                    ii = i + 1; jj = j - 1;
                    while (ii < 8 && jj >= 0)
                    {
                        if (B[ii, jj] == turn || B[ii, jj] == "E")
                            break;
                        ii++; jj--;
                    }
                    if (ii < 8 && jj >= 0 && B[ii, jj] == "E" && ii != i+1 && jj!=j-1)
                    {
                        Move m = new Move();
                        m.i = ii; m.j = jj;
                        al.Add(m);

                    }

                    //to down-right
                    ii = i + 1; jj = j + 1;
                    while (ii < 8 && jj < 8)
                    {
                        if (B[ii, jj] == turn || B[ii, jj] == "E")
                            break;
                        ii++; jj++;
                    }
                    if (ii < 8 && jj < 8 && B[ii, jj] == "E" && ii != i+1 && jj!=j+1)
                    {
                        Move m = new Move();
                        m.i = ii; m.j = jj;
                        al.Add(m);

                    }
                }

            }

        return Remove_Duplication(al);

    }

    public Move getBestMove(String [,] board,int depth,String color)
    {
        int positionCount = 0;
        Move bestMove = minimaxRoot(board,depth, true);
        return bestMove;
    }

    public Move minimaxRoot (String[,] board,int depth,bool isMaximisingPlayer) {
        List<Move> newGameMoves = new List<Move>();
        if (isMaximisingPlayer)
            newGameMoves = findlegalMovesCount(board,"B");
        else
        {
            newGameMoves = findlegalMovesCount(board, "W");
        }
    float bestMove = -9999;
    Move bestMoveFound=null;

    for(var i = 0; i<newGameMoves.Count; i++) {
            Move newGameMove = newGameMoves[i];
            String[,] b;
            if (!isMaximisingPlayer)
            {
                b = InsertWhitePiece_Board(newGameMove.i, newGameMove.j, board);
            }
            else
            {
               b = InsertBlackPiece_Board(newGameMove.i, newGameMove.j, board);
            }
       
        var value = minimax(b,depth - 1, -10000, 10000, !isMaximisingPlayer);
        if(value >= bestMove) {
            bestMove = value;
            bestMoveFound = newGameMove;
        }
    }
    return bestMoveFound;
}

 public float minimax (String [,] board,int depth,  float alpha,float beta, bool isMaximisingPlayer) {
    if (depth == 0) {
            if(isMaximisingPlayer)
                 return -Evaluate(board,"B");
            else
            {
                return -Evaluate(board, "W");
            }
    }
        String color = "W";
        if (isMaximisingPlayer)
            color = "B";

        List<Move> newGameMoves = findlegalMovesCount(board, color);
        if (isMaximisingPlayer) {
        float bestMove = -9999;
        for (var i = 0; i<newGameMoves.Count; i++) {
                String[,] b;
                if (color == "W")
                {
                    b = InsertWhitePiece_Board(newGameMoves[i].i, newGameMoves[i].j, board);
                }
                else
                {
                    b = InsertBlackPiece_Board(newGameMoves[i].i, newGameMoves[i].j, board);
                }
                bestMove = Math.Max(bestMove, minimax(b,depth - 1,alpha, beta, !isMaximisingPlayer));
            alpha = Math.Max(alpha, bestMove);
            if (beta <= alpha) {
                return bestMove;
            }
        }
        return bestMove;
    } else {
        float bestMove = 9999;
        for (var i = 0; i<newGameMoves.Count; i++) {
                String[,] b;
                if (color == "W")
                {
                    b = InsertWhitePiece_Board(newGameMoves[i].i, newGameMoves[i].j, board);
                }
                else
                {
                    b = InsertBlackPiece_Board(newGameMoves[i].i, newGameMoves[i].j, board);
                }
                bestMove = Math.Min(bestMove, minimax(b,depth - 1, alpha, beta, !isMaximisingPlayer));
            beta = Math.Min(beta, bestMove);
            if (beta <= alpha) {
                return bestMove;
            }
        }
        return bestMove;
    }
}


}
