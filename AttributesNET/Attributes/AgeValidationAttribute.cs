namespace AttributesNET.Attributes
{
    public class AgeValidationAttribute : System.Attribute
    {
        public int Age { get; set; }

        public AgeValidationAttribute()
        { }

        public AgeValidationAttribute(int age)
        {
            Age = age;
        }
    }
}
