using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;


namespace CGO_Buoi12_TicTacToe
{
    class TicTacToe
    {
        //Khoi tao
        public TicTacToe()
        {
            play();
        }

        //Luot choi
        public void play()
        {
            int moveCounter = 0;
            Board gameBoard = new Board();

            Player playerX = new Player('X');
            Player playerO = new Player('O');
            Robot botCounter = new Robot();
            Player currentPlayer = playerX;
            bool botX = false, botO = false, modeIsOk = false; string name = "None" ;
            int mode;
            
            while (!modeIsOk) { 

                repeat:
                Console.WriteLine("Chon che do choi");
                Console.WriteLine("1. Nguoi voi nguoi\n2. Nguoi voi may\n3. May voi may");
                try { 
                    mode = Int32.Parse(Console.ReadLine());
                    if (mode <1 || mode >3)
                    {
                        Console.WriteLine("Loi che do");
                        goto repeat;
                    }
                }
                 catch (Exception ex)
                    {
                        Console.WriteLine("Loi khong xac dinh!" + ex.Message);
                        goto repeat;
                    }
                
            
                switch (mode)
                {
                    case 1:
                        modeIsOk = true;
                        Console.WriteLine("Moi nhap ten(he thong se tinh diem la so luot da choi): ");
                        name = Console.ReadLine();
                        break;
                    case 2:
                        modeIsOk = true;
                        botO = true;
                        Console.WriteLine("Moi nhap ten(he thong se tinh diem la so luot da choi): ");
                        name = Console.ReadLine();
                        break;
                    case 3:
                        modeIsOk = true;
                        botX = true;
                        botO = true;
                        break;
                    default:
                        
                        Console.Clear();
                        Console.WriteLine("Che do choi khong hop le, moi nhap lai");
                        break;

                }
            }
            Console.Clear();
            string path = "Score\\"+name+".txt";

            bool play = true;
            while (play)
            {
                gameBoard.printBoard();
                Console.WriteLine("Player: {0} Enter the field in which you want to put the character: ", currentPlayer.getSign());

                try
                {
                    int choice;
                    foreach (int i in botCounter.lstNumber) Console.WriteLine(i);

                    if ((botX == true && currentPlayer.getSign() == 'X') || (botO == true && currentPlayer.getSign() == 'O'))
                    {
                        Thread.Sleep(1000);
                        choice = botCounter.takeTurn();
                        Console.WriteLine("Bot "+currentPlayer.getSign()+" choice:" + choice);
                        Thread.Sleep(1500);
                        gameBoard.putMark(currentPlayer, choice);

                    }
                    else
                    {
                        choice = playerX.takeTurn();
                        botCounter.lstNumber.Remove(choice);
                        gameBoard.putMark(currentPlayer, choice);

                    }
                    
                    gameBoard.clearBoard();
                    moveCounter++;

                    if (currentPlayer.checkWin(gameBoard))
                    {
                        Console.WriteLine("Player: {0} won!", currentPlayer.getSign());
                        gameBoard.printBoard();
                        play = false;
                    }
                    else if (checkDraw(moveCounter))
                    {
                        Console.WriteLine("DRAW");
                        gameBoard.printBoard();
                        play = false;
                    }
                    currentPlayer = (moveCounter % 2 == 0) ? playerX : playerO;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input. Please enter number between 1-9!");
                    Console.ReadLine();
                    Console.Clear();
                }
            

            // Tạo một file mới và ghi nội dung vào đó.
                
            }
            if(name != "None")
            {
                FileInfo fi = new FileInfo(path);
                int score = 1;
                if (fi.Exists)
                {
                    using (StreamReader reader = new StreamReader(path))
                    {
                        string line;
                        line = reader.ReadLine();
                        {
                            score = int.Parse(line);
                            score++;
                        }
                    }
                    fi.Delete();
                }
                DateTime localDate = DateTime.Now;
                using (StreamWriter writer = new StreamWriter(path))
                {
                        writer.WriteLine(score);
                        writer.WriteLine(localDate);
                }
                
                
            Console.WriteLine("Nguoi choi {0} dang co {1} diem. Thoi diem hien tai cua he thong la {2}",name,score, localDate);
            }
        }

        //Kiem tra luot di cuoi
        private bool checkDraw(int turnCounter)
        {
            if (turnCounter == 9)
                return true;
            return false;
        }
    }
}
