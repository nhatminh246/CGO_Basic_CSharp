namespace UngDungDocSoThanhChu;
class Program
{
    static void Main(string[] args)
    {   
        //input  
        bool isok = true;
        string s_hundered = "", s_tens = "", s_ones = "", answer, mix="",s_num ;
        int hundered = 0, tens = 0, ones = 0, num;
        Console.Write("Enter your number: ");
        num = Int32.Parse(Console.ReadLine());
        // lay do dai cua xau va lay cac gia tri hang don vi, chuc, tram
        answer = (num<0)? "minus ": "";
        num = (num<0)? -num: num;
        s_num =  num.ToString();
        
        int len = s_num.Length;
        switch (len){
            case 3:
                hundered = (num / 100) % 10;
                goto case 2;
            case 2:
                tens = (num / 10) % 10;
                goto case 1;
            case 1:
                ones = num % 10;
                break;
            default:
                isok = false;
                break;
        }

        // kiem tra truong hop dac biet
        if(10<=(ones + tens*10) && (ones + tens*10) <20 ){
            switch (ones + tens*10){
                case 10:
                    mix = "ten";
                    break;
                case 11:
                    mix = "eleven";
                    break;
                case 12:
                    mix ="twelve";
                    break;
                case 13:
                    mix = "thirteen";
                    break;
                case 14:
                    mix = "fourteen";
                    break;
                case 15:
                    mix = "fifteen";
                    break;
                case 16:
                    mix = "sixteen";
                    break;
                case 17:
                    mix = "seventeen";
                    break;
                case 18:
                    mix = "eighteen";
                    break;
                case 19:
                    mix = "nineteen";
                    break;       
            }
        }

        // truong hop binh thuong
        //hang tram
        switch(hundered){
            case 1:
                s_hundered = "one hundered";
                break;
            case 2:
                s_hundered = "two hundered";
                break;
            case 3:
                s_hundered = "three hundered";
                break;
            case 4:
                s_hundered = "four hundered";
                break;
            case 5:
                s_hundered = "five hundered";
                break;
            case 6:
                s_hundered = "six hundered";
                break;
            case 7:
                s_hundered = "seven hundered";
                break;
            case 8:
                s_hundered = "eight hundered";
                break;
            case 9:
                s_hundered = "nine hundered";
                break;
        }
        //hang chuc
        switch (tens){
            case 2:
                s_tens= "twenty";
                break;
            case 3:
                s_tens= "thirty";
                break;
            case 4:
                s_tens= "forty";
                break;
            case 5:
                s_tens= "fifty";
                break;
            case 6:
                s_tens= "sixty";
                break;
            case 7:
                s_tens= "seventy";
                break;
            case 8:
                s_tens= "eighty";
                break;
            case 9:
                s_tens= "ninety";
                break;
        }
        //hang donvi
        switch (ones){
            case 1:
                s_ones = "one";
                break;
            case 2:
                s_ones = "two";
                break;
            case 3:
                s_ones = "three";
                break;
            case 4:
                s_ones = "four";
                break;
            case 5:
                s_ones = "five";
                break;
            case 6:
                s_ones = "six";
                break;
            case 7:
                s_ones = "seven";
                break;
            case 8:
                s_ones = "eight";
                break;
            case 9:
                s_ones = "nine";
                break;
        }
        //ket noi xau
        if(mix==""){
                mix = s_tens +" "+ s_ones;
        }
        //isok = false tuc la so co hon 3 chu so
        if(isok){
            if(s_hundered != "" && mix !=""){
                answer += s_hundered +" and "+ mix;
            }else if(num == 0){
                answer = "zero";
            }else {
                answer += s_hundered +" " + mix;
            }
        }else{
            answer = "out of ability";
        }
        Console.WriteLine(answer);
        
    }
}

