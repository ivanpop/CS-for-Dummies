namespace Chapter_14_Solution_1
{
    internal class Student
    {
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public enum speciality
        {
            CSharp,
            Java,
            Python
        }
        public enum university 
        {
            Plovdiv_University,
            Sofia_University,
            Varna_University
        }
        public string email { get; set; }
        public string mobileNumber { get; set; }
    }
}