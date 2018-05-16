﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SalaryCapData.Data.Models;

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

		IEnumerable<Player> GetPlayers( int id );
		void AddPlayer( int franchiseId, int playerId );
		void Droplayer( int franchiseId, int playerId );


		string OwnerId( int id );
		ApplicationUser Owner( int id );

		int LeagueId( int id );
		League League( int id );

	}
}
