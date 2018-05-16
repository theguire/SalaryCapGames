//using System.Collections.Generic;
//using System.Linq;
//using Microsoft.EntityFrameworkCore;
//using SalaryCapData;
//using SalaryCapData.Data;
//using SalaryCapData.Data.Models;
//using SalaryCapData.Interfaces;

//namespace SalaryCapServices
//{
//	public class OwnerService : IOwner

//	{
//		private ApplicationDbContext _ownerDbContext;

//		public OwnerService( ApplicationDbContext ownerDbContext )
//		{
//			_ownerDbContext = ownerDbContext;
//		}

//		public void Add( Owner newOwner )
//		{
//			_ownerDbContext.Add( newOwner );
//			_ownerDbContext.SaveChanges();
//		}

//		public Owner Get( int id )
//		{
//			return (GetAll().FirstOrDefault( o => (o.Id == id) ));
//		}

//		public IEnumerable<Owner> GetAll()
//		{
//			return (_ownerDbContext.Owners
//									.Include( f => f.Franchises )
//									.Include( f => f.Leagues ));
//			;
//			//.ThenInclude( f => f.League ));

//		}

//		public void Update( Owner owner )
//		{
//			_ownerDbContext.Update( owner );
//			_ownerDbContext.SaveChanges();
//		}

//		public bool OwnerExists( int id )
//		{
//			return _ownerDbContext.Owners.Any( e => e.Id == id );
//		}

//		//public virtual void AddFranchise( int id, string franchiseName)
//		//{
//		//    _ownerDbContext.Franchises.Add( new Franchise
//		//    {
//		//        OwnerId = id,
//		//        Name = franchiseName
//		//    } );
//		//}
//		public IEnumerable<Franchise> Franchises( int id )
//		{
//			return _ownerDbContext.Franchises
//							.Include( f => f.League )
//							.Where( o => o.Owner.Id == id );
//		}

//		public IEnumerable<League> Leagues( int id )
//		{
//			return _ownerDbContext.Leagues
//				.Where( o => o.Commissioner.Id == id );
//		}

//		public bool Any()
//		{
//			return _ownerDbContext.Owners != null;
//		}

//		public int GetOwnerId( int AppUserId )
//		{
//			return _ownerDbContext.Owners.FirstOrDefault( o => (o.AppUserId == AppUserId) ).Id;
//		}
//	}

//}
