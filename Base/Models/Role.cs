namespace Models
{
    public class Role
    {
        public string Name { get; set; }
        List<Permission> Permissions { get; set; }
        List<User> Users { get; set; }
    }
}
