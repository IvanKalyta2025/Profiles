
namespace api.Dtos
{
    public class SkillDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public UserDto User { get; set; } = null!;
    }
}

//у меня есть профиль, и у него есть отдельный блок для skill. skill связан с user 
//значит мне нужно передать просто skill в запросе по id и привязать его к user.