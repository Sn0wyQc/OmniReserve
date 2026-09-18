using FluentValidation;

namespace OmniReserve.Application.Rooms.Commands.CreateRoom;

public class CreateRoomCommandValidator : AbstractValidator<CreateRoomCommand>
{
    public CreateRoomCommandValidator()
    {
        RuleFor(command => command.RoomNumber)
            .NotEmpty()
            .MaximumLength(5);

        RuleFor(command => command.PricePerNight)
            .GreaterThan(0);
    }
}