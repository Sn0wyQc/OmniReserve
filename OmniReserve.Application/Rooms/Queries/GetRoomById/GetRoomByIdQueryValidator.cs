using FluentValidation;
using OmniReserve.Application.Rooms.Queries.GetRoomById;

namespace OmniReserve.Application;

public class GetRoomByIdQueryValidator : AbstractValidator<GetRoomByIdQuery>
{
    public GetRoomByIdQueryValidator()
    {
        RuleFor(x => x.RoomId)
            .NotEmpty()
            .WithMessage("El identificador de la habitación es obligatorio.");
            //. 
    }
}
