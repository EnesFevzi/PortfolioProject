using PortfolioProject.DataAccess.Context;
using PortfolioProject.DataAccess.Repositories.Abstract;
using PortfolioProject.DataAccess.Repositories.Concrete;
using PortfolioProject.DataAccess.UnıtOfWorks.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.DataAccess.UnıtOfWorks.Concrete
{
	public class UnitOfWork : IUnıtOfWork
	{
		private readonly AppDbContext _dbContext;

		public UnitOfWork(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public async ValueTask DisposeAsync()
		{
			await _dbContext.DisposeAsync();
		}

		public int Save()
		{
			return _dbContext.SaveChanges();
		}

		public async Task<int> SaveAsync()
		{
			return await _dbContext.SaveChangesAsync();
		}


		IRepository<T> IUnıtOfWork.GetRepository<T>()
		{
			return new Repository<T>(_dbContext);
		}
	}
}
