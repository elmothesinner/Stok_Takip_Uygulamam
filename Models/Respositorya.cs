namespace BtkAkademi.Models
{
    public static class ResopA
    {
        private static readonly List<Admin> applications = new();

        public static IEnumerable<Admin> Applications => applications;


        public static void Add(Admin Admin)
        {
            applications.Add(Admin);
        }
    
    }
}