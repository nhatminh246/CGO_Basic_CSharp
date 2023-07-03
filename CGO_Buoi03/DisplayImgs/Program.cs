

namespace MenuDesign
{
    class Program
    {
        static void DrawSquareTriTopLeft(){
            for(int i = 5; i >=1; i--){
                for(int j = i; j >=1; j--){
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine();
        }

        static void DrawSquareTriTopRight(){
            for(int i = 1; i <=5; i++){
                for(int j = 1; j < i; j++){
                    Console.Write("  ");
                } 
                for(int j = i; j <=5; j++){
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine();
        }

        static void DrawSquareTriBottomLeft(){
            for(int i = 1; i <=5; i++){
                for(int j = 1; j <= i; j++){
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine();
        }
        
        static void DrawSquareTriBottomRight(){
            for(int i = 5; i >=1; i--){
                for(int j = 1; j < i; j++){
                    Console.Write("  ");
                } 
                for(int j = i; j <=5; j++){
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine();
        }

        static void DrawIsoscelesTri(){
            for(int i = 7 ; i >=1 ; i--){
                for(int j = 1;j<=i ; j++){
                    Console.Write("  ");
                }
                for(int j = 8-i+2*(7-i); j <=8-i+4*(7-i); j++){
                    Console.Write("* ");
                }
                Console.WriteLine();
                
            }
        }
        static void DrawRectangle(){
            for(int i = 0; i <= 3; i++){
                for(int j = 0; j <=7; j++){
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            
                Console.WriteLine("Menu");
                Console.WriteLine("1. Draw the rectangle");
                Console.WriteLine("2. Draw the square triangle");
                Console.WriteLine("3. Draw the isosceles triangle");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                int choice = Int32.Parse(Console.ReadLine());
                
                    switch (choice)
                    {
                        case 1:
                            DrawRectangle();
                            break;
                        case 2:
                            
                            Console.WriteLine("Choose the shape of the right triangle ");
                            Console.WriteLine("1. Draw the square triangle top-left");
                            Console.WriteLine("2. Draw the square triangle top-right ");
                            Console.WriteLine("3. Draw the square triangle bottom-left");
                            Console.WriteLine("3. Draw the square triangle bottom-right");
                            Console.WriteLine("0. Exit");
                            Console.WriteLine("Enter your choice: ");
                            int choice_tri = Int32.Parse(Console.ReadLine());
                            switch (choice_tri){
                                
                                case 1:
                                    DrawSquareTriTopLeft();
                                    break;
                                case 2:
                                    DrawSquareTriTopRight();
                                    break;
                                case 3:
                                    break;
                                case 4:
                                    DrawSquareTriBottomRight();
                                    break;
                                default:
                                    Console.WriteLine("No choice!");
                                    break;
                            }
                            
                            break;
                        case 3:
                            DrawIsoscelesTri();
                            break;
                        case 0:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("No choice!");
                            break;
                    }

            }


        }
    }
