using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{ 

    public class Model
    {
        Observable obs; 

        private string[] board;
        private int PushButton = -1;
        private string ActivePlayer = "X";
        private bool PlayerSet = false;
        private bool StartAgain = false;
        private bool Reset = false;
        private bool Win = false;
        private int Draw = 0;
     public Model()
        {
            obs = new Observable();
            board = new string[9];
            for (int i = 0; i < 9; i++)
            {
                board[i] = "" + 1;
            }
        }
        public void MakeMove(int i)
        {
            PushButton = i;
            board[PushButton] = ActivePlayer;
            Draw++;
            obs.SetChanged();
            obs.NotifyObservers();      
        }
        public int GetPushButton()
        {
            return PushButton;
        }

        public string GetActivePlayer()
        {
            return ActivePlayer;
        }
        public void ChangeActivePlayer()
        {
            if (ActivePlayer.Equals("X"))
                ActivePlayer = "O";
            else
                ActivePlayer = "X";
        }
        //startar om spelet------------------------------------------------
        public void Restart()
        {
            for (int i = 0; i < 9; i++)
                board[i] = "" + i;
            Reset = true;
            Win = false;
            Draw = 0;
            PushButton = -1;
            obs.SetChanged();
            obs.NotifyObservers();
        }
        public bool CheckReset()
        {
            if (Reset)
            {
                Reset = false;
                return true;
            }
            else
                return false;
        }
        //starta nytt spel-----------------------------------------------------
        public void NewGame()
        {
            StartAgain = true;
            Restart();
        }
        public bool CheckStartAgain()
        {
            if (StartAgain)
            {
                StartAgain = false;
                return true;
            }
            else
                return false;
        }
        public void AddPlayer()
        {
            PlayerSet = true;
            obs.SetChanged();
            obs.NotifyObservers();
        }
        public bool CheckPlayer()
        {
            if (PlayerSet)
            {
                PlayerSet = false;
                return true;
            }
            return false;
        }
        //Vilkor för att vinna
        public bool CheckWin()
        {
            if (board[0].Equals(board[1]) && board[0].Equals(board[2]))
            {             
                return true;
            }
            else if (board[3].Equals(board[4]) && board[3].Equals(board[5]))
            {               
                return true;
            }
            else if (board[6].Equals(board[7]) && board[6].Equals(board[8]))
            {       
                return true;
            }
            else if (board[0].Equals(board[3]) && board[0].Equals(board[6]))
            {
                return true;
            }
            else if (board[1].Equals(board[4]) && board[1].Equals(board[7]))
            {
                return true;
            }
            else if (board[2].Equals(board[5]) && board[2].Equals(board[8]))
            {
                return true;
            }
            else if (board[0].Equals(board[4]) && board[0].Equals(board[8]))
            {
                return true;
            }
            else if (board[2].Equals(board[4]) && board[2].Equals(board[6]))
            {
                return true;
            }
            return Win;
        }
        public bool CheckDraw()
        {
            if (Draw == 9)
                return true;
            else
                return false;
        }
        //public void Update(object arg0, object arg1)
        //{
        //    throw new NotImplementedException();
        //}
    }
        
}

