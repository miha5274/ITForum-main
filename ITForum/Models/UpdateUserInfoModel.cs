﻿namespace ITForum.Api.Models
{
    public class UpdateUserInfoModel
    {
        public string? FirstName { get; set; } = null!;
        public string? LastName { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public string? Avatar { get; set; } = null!;
        public string? Location { get; set; } = null!;
        public string? Study { get; set; } = null!;
        public string? Work { get; set; } = null!;
        public DateTime? BirthDate { get; set; } = null!;
    }
}
