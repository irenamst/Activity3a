using Activity3a.Models;
using System.Globalization;

namespace Activity3a.ServicesAirline
{
    public class HardCodedDataRepository : IAirlineDataService
    {
        List<AirlineTicketModel> airlineTicketsList = new List<AirlineTicketModel>();
        public int Delete(AirlineTicketModel airlineTicket)
        {
            throw new NotImplementedException();
        }

        public AirlineTicketModel GetAirlineTicketById(int id)
        {
           throw new NotImplementedException();
        }

        public List<AirlineTicketModel> GetAllAirlineTickets()
        {
            DateOnly dt1 = new DateOnly(2022, 02, 02 ,new CultureInfo("bg-BG",false).Calendar);
            
            airlineTicketsList.Add(new AirlineTicketModel
            {
                Id = 1,
                City1="Sofia",
                City2="Varna",
                Date = dt1.ToString("dd/MM/yyyyг."),

            });

            DateOnly dt2 = new DateOnly(2022, 02, 03, new CultureInfo("bg-BG",false).Calendar);
            airlineTicketsList.Add(new AirlineTicketModel
            {
                Id = 2,
                City1 = "Sofia",
                City2 = "Bulgas",
                Date = dt2.ToString("dd/MM/yyyyг."),
            });

            DateOnly dt3 = new DateOnly(2022, 02, 04, new CultureInfo("bg-BG", false).Calendar);
            airlineTicketsList.Add(new AirlineTicketModel
            {
                Id = 3,
                City1 = "Sofia",
                City2 = "Frankfurt",
                Date = dt3.ToString("dd/MM/yyyyг."),
            });
            DateOnly dt4 = new DateOnly(2022, 02, 05, new CultureInfo("bg-BG", false).Calendar);
            airlineTicketsList.Add(new AirlineTicketModel
            {
                Id = 4,
                City1 = "Sofia",
                City2 = "Helsinki",
                Date = dt4.ToString("dd/MM/yyyyг."),
            });
            return airlineTicketsList;
        }

        public int Insert(AirlineTicketModel airlineTicket)
        {
            throw new NotImplementedException();
        }

        public List<AirlineTicketModel> SearchAirlineTickets(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int Update(AirlineTicketModel airlineTicket)
        {
            throw new NotImplementedException();
        }
    }
}
