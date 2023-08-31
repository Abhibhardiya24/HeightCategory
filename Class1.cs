namespace HeightCategory
{
    public class Class1
    {
        class Program
        {
            static void Main()
            {
                int Height = 75;
                double inch = 2.54;
                double HeightinCM = Height * inch;
                string result = null;

                if (HeightinCM < 150)
                {

                    result = "Dwarf";
                }

                else if (HeightinCM > 150 && HeightinCM < 165)
                {
                    result = "Average Height";
                }
                else if (HeightinCM > 165 && HeightinCM < 195)
                {

                    result = "Tall";
                }


                else
                {

                    result = "Abnormal Height";
                }



                Console.WriteLine(result);
                Console.ReadKey();


            }
        }
    }
}