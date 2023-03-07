namespace Models
{
    public class Permission
    {
        public string Description { get; set; }
        public List<Role> Roles { get; set; }
    }
}
