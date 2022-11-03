namespace EmptyMVC.Models
{
    public class Doctor
    {
        public static string TestForFever(double temp)
        {
            return (temp > 37) ? "Doctor says you have fever...Take more liquids" : "Doctor says you have no fever...";

        }

        internal static dynamic TestFever(double temp)
        {
            throw new NotImplementedException();
        }
    }
}
