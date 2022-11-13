using System.ComponentModel;

namespace Model
{
    public class User
    {
        /// <summary>
        /// user Id
        /// </summary>
        public int userId { get; set; }
        /// <summary>
        /// User Name
        /// </summary>
        public string? userName { get; set; }
        /// <summary>
        /// User Email
        /// </summary>
        public string? email { get; set; }
        /// <summary>
        /// User Mobile Number
        /// </summary>
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