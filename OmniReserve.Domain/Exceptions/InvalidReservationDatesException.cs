namespace OmniReserve.Domain;

public class InvalidReservationDatesException : DomainException
{
    public InvalidReservationDatesException() 
        : base("La fecha de Check-out debe ser posterior a la fecha de Check-in")
    {
    }
}