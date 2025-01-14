//using System;

//namespace Tdd

//{

//    public sealed class EmailService
//    {
//        private List<string> _sentEmails = new List<string>();
//        private EmailService() { }

//        public static EmailService _email;
//        public static EmailService EmailCreate()
//        {

//            if (_email == null)
//            {

//                Console.WriteLine("email Made");
//                _email = new EmailService();

//            }
//            else
//            {
//                Console.WriteLine("email Is Busy Please Wait");
//            }

//            return _email;
//        }

//        public void SendEmail(string text, string user)
//        {
//            string key = text + " - " + user;
//            if (!_sentEmails.Contains(key))
//            {

//                _sentEmails.Add(key);
//                Console.WriteLine(text + " Sended To " + user);

//            }




//        }



//    }




//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            EmailService email1 = EmailService.EmailCreate();
//            email1.SendEmail("hello", "ali");
//            email1.SendEmail("hello", "ali");
//            email1.SendEmail("Bye", "hosein");

//            EmailService email2 = EmailService.EmailCreate();
//            email2.SendEmail("Bye", "hosein");
//            email2.SendEmail("Bye", "ali");



//        }
//    }
//}
