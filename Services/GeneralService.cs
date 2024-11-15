using Assesment.Data;

namespace HotelManagementAndReservation.Services;
public class GeneralService
{
    protected readonly AppDbContext _context;

    public GeneralService(AppDbContext context)
    {
        _context = context;
    }
}