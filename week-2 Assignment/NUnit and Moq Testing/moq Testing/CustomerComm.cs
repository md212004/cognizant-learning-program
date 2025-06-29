namespace CustomerCommLib
{
    public class CustomerComm
    {
        private IMailSender _mailSender;

        // Constructor Injection
        public CustomerComm(IMailSender mailSender)
        {
            _mailSender = mailSender;
        }

        public bool SendMailToCustomer()
        {
            string to = "cust123@abc.com";
            string msg = "Some Message";

            return _mailSender.SendMail(to, msg);
        }
    }
}
