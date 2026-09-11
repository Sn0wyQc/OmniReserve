using MediatR;
using OmniReserve.Domain;

namespace OmniReserve.Application;

public class CreateRoomCommand : IRequest<Guid>
{
	public string RoomNumber { get; set; }
	public RoomType Type { get; set; }
	public decimal PricePerNight { get; set; }
}
        