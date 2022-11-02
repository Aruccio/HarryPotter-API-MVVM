using HarryPotter.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.MainApplication.Services
{
    public interface ICharacterRepository
    {
        Task<ICollection<Character>> GetAllCharacters();

    }
}