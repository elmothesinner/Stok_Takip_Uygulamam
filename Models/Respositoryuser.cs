namespace BtkAkademi.Models
{
    public static class RespU
    {
        private static readonly List<Uye> applications = new();

        public static IEnumerable<Uye> Applications => applications;

        /*private static List<Candidate> applications = new();
        public static IEnumerable<Candidate> Applications => applications;
*/
        public static void Add(Uye Uye)
        {
            applications.Add(Uye);
        }
    
    }
}