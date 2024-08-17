using System;

namespace Auth.API.Models.Dto;

public class RegisterationRequestDto
{
    public string Email { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string PhoneNumber { get; set; }

    public string Password { get; set; }

    public string? Role { get; set; }
}