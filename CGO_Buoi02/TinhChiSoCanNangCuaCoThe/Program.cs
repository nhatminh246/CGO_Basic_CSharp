namespace bmi_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double height, weight, bmi;

            Console.Write("Please enter a height(meter): ");
            height = float.Parse(Console.ReadLine());
            Console.Write("Please enter your weight(kg): ");
            weight = float.Parse(Console.ReadLine());

            bmi = weight / Math.Pow(height,2);
            bmi = Math.Round(bmi, 1);

            Console.Write("BMI: "+ bmi);

            if (bmi < 18.5)
                Console.WriteLine(" Underweight");
            else if (bmi < 25.0)
                Console.WriteLine(" Normal");
            else if (bmi < 30.0)
                Console.WriteLine(" Overweight");
            else
                Console.WriteLine(" Obese");

        }
    }
}