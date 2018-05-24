using SalaryCapData.Data.Models;

using System.Collections.Generic;

namespace SalaryCapData.Interfaces
{
    public interface IFranchise
    {
        IEnumerable<Franchise> GetAll();
        Franchise Get( int id );
        IEnumerable<Franchise> GetAllByOwnerId( string ownerId );

        void Add( Franchise newFranchise );
        void Update( Franchise franchise );

        string Name( int id );
        string AbbrevName( int id );
        string ImageUrl( int id );

        bool Any( int id );

        long PointTotal( int id );
        decimal FranchiseValue( int id );
        int NumberOfTrades( int id );

        //FranchisePlayers GetPlayers( int id );
        //void AddPlayer( int franchiseId, int playerId );
        void Droplayer( int franchiseId, int playerId );


        string OwnerId( int id );
        ApplicationUser Owner( int id );

        int LeagueId( int id );
        League League( int id );

    }
}
