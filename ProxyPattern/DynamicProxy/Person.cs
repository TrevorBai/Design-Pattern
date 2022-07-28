namespace DynamicProxy
{
    public class Person : IPerson
    {
        private string _name;
        private string _gender;
        private string _interests;
        private int _rating;
        private int _ratingCount = 0;

        public Person()
        {
        }

        public string GetName()
        {
            return _name;
        }

        public string GetGender()
        {
            return _gender;
        }

        public string GetInterests()
        {
            return _interests;
        }

        public int GetGeekRating()
        {
            if (_ratingCount == 0) return 0;
            return _rating / _ratingCount;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void SetGender(string gender)
        {
            _gender = gender;
        }

        public void SetInterests(string interests)
        {
            _interests = interests;
        }

        public void SetGeekRating(int rating)
        {
            _rating += rating;
            _ratingCount++;
        }
    }
}
