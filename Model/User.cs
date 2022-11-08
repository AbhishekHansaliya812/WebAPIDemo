using System.ComponentModel;

namespace Model
{
    public class User
    {
        public int userId { get; set; }
        public string? userName { get; set; }
        public string? email { get; set; }
        public long mobileNumber { get; set; }
        public User(int UserId, string? UserName, string? Email, long MobileNumber)
        {
            userId = UserId;
            userName = UserName;
            email = Email;
            mobileNumber = MobileNumber;
        }
    }
}