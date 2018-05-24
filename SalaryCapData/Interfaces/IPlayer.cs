using SalaryCapData.Data.Models;

using System.Collections.Generic;

namespace SalaryCapData.Interfaces
{
    public interface IPlayer
    {
        IEnumerable<Player> GetAll();
        IEnumerable<Player> GetAll( int count );



        Player Get( int PlayerId );

        void Add( Player newPlayer );
        void Update( Player player );
        bool Exists( int id );

        void AddPitcherStats( PitcherStats stats );
        void AddHitterStats( HitterStats stats );

        void AddPlayerPosition( PlayerPosition playerPosition );

        HitterStats GetPlayerHitterStats( int playerId );
        PitcherStats GetPlayerPitcherStats( int playerId );

        IEnumerable<HitterStats> GetHitterStats();
        IEnumerable<PitcherStats> GetPitcherStats();

        IEnumerable<HitterStats> GetHitterStats( int count );
        IEnumerable<PitcherStats> GetPitcherStats( int count );

        void DraftPlayer( PlayerAssignment player );

        IEnumerable<PlayerAssignment> GetFranchisePlayers( int franchiseId );

        //IEnumerable<StatsIndexListModel> GetAllPlayerStats();
        //IEnumerable<StatsIndexListModel> GetAllPlayerStats( int count );



    }
}
