namespace Backend.DTO
{
    public class CreateUserDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // Uno o más roles
        public List<int> RoleIds { get; set; }
    }
}
