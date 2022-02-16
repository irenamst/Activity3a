using Activity3a.Models;
namespace Activity3a.ServicesAirline
{
    public interface IAirlineDataService
    {
        List<AirlineTicketModel> GetAllAirlineTickets();
        List<AirlineTicketModel> SearchAirlineTickets(string searchTerm);
        AirlineTicketModel GetAirlineTicketById(int id);
        int Insert(AirlineTicketModel airlineTicket);
        int Delete(AirlineTicketModel airlineTicket);
        int Update(AirlineTicketModel airlineTicket);
    }
}
