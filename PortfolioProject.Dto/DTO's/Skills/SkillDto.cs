namespace PortfolioProject.Dto.DTO_s.Skills
{
    public class SkillDto
    {
        public Guid SkillID { get; set; }
        public string Title { get; set; }
        public int Value { get; set; }
        public string CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
       
    }
}
