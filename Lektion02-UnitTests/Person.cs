namespace Lektion2
{
    public class Person
    {
        private string name;
        public float weight;
        public float height;
        public float bmi;

        public float GetBodyMassIndex()
        {
            return weight / (height * height);
        }

        public string GetClassification(float bmi)
        {
            if (bmi < 18.5f)
                return "Underweight";

            if (bmi > 18.5f && bmi < 24.9f)
                return "Normal weight";

            if (bmi > 25f && bmi < 29.9f)
                return "Overweight";

            if (bmi > 30f)
                return "Obesity";

            return "None";
        }
    }
}