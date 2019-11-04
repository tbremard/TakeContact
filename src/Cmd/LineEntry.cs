namespace Cmd
{
    public class LineEntry
    {
        public string FirstName{get; set;}
        public string LastName { get; set; }
        public string Email { get; set; }
        public static LineEntry CreateFake()
        {
            LineEntry ret = new LineEntry();
            ret.Email = "mail@mail.fr";
            ret.FirstName = "firstname";
            ret.LastName = "lastname";
            return ret;
        }
    }
}
