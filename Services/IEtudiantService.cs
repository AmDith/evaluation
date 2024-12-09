
using WebApplication2.Models;

namespace gestionDetteWeb2.Services;

public interface IEtudiantService
{
    Task<IEnumerable<Inscription>> GetInscriptionsAsync();
    Task<Inscription> Create( Inscription inscription);
}