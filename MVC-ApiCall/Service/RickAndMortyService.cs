using MVC_ApiCall.Models;
using MVC_ApiCall.Repository;

namespace MVC_ApiCall.Service
{

    public interface IRickAndMortyService
    {
        public CharacterResults GetCharacters();
    }

    public class RickAndMortyService:IRickAndMortyService
    {
        public IRickAndMortyRepository _rickandmortyRepository;
        
        public RickAndMortyService(IRickAndMortyRepository repository)
        {
            _rickandmortyRepository = repository;
        }

        public CharacterResults GetCharacters()
        {
            // repository'e erişmemiz lazım

            return _rickandmortyRepository.GetCharacters();
        }
    }
}
