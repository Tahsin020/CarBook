﻿namespace CarBook.Application.Features.CQRS.Commands.ContactCommands;
public sealed class UpdateContactCommand
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public string Message { get; set; }
    public DateTime SendDate { get; set; }
}
