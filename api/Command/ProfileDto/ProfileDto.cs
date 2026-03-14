using api.Dtos;

namespace api.Dtos
{
    public class ProfileDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Skills { get; set; } = string.Empty;
        public string Application { get; set; } = string.Empty;
        public UserDto User { get; set; } = null!;
    }
}