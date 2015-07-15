namespace InheritanceAndPolymorphism
{
    using System;

    public static class Validator
    {
        public static void ValidateNullOrEmpty(string value, string propertyName)
        {
            if (string.IsNullOrEmpty(value.ToString()))
            {
                throw new ArgumentNullException(string.Format("{0} cannot be null or empty", propertyName));
            }
        }

        public static void ValidateNull<T>(T value, string propertyName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(string.Format("{0} cannot be null", propertyName));
            }
        }
    }
}
