using System;
using System.Collections.Generic;
using System.Text;
using SalaryCapData.Data.Models;

namespace SalaryCapData.Interfaces
{
    public interface ITeam
    {
        IEnumerable<Team> GetAll();
        Team Get( int id );
        bool Exists( int id );
        void Add( Team newTeam );
       
    }
}