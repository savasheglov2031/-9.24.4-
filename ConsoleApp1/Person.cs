namespace KT1
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;

        public string FirstName =>_firstName;
        public string LastName =>_lastName;
        public int Age =>_age;

        public Person(string firstName, string lastName, int age)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age >= 0 ? age : 0; // защита от отрицательного возраста
        }
    }
}