namespace Forms_Inputs.Helpers
{
    public class FeverResult
    {
        public static string Test(double temp)
        {
            
            if (temp < 30)
                    return "Yes had to be die you are like a freaze....";

            if (temp < 37)
                    return "you are cold you have to get warm ....";

            if(temp == 37)
                    return "you are so good. your tempreture is normal .. perfect.";

            if (temp > 37 && temp < 40)
                return "you have a fever .. you have to go home and take a medicine";

            else
                return "you are so hot ... it's dangerous";
            
        }
    }
}
