using System;
using System.Collections.Generic;
using System.Data;
using Keepr.Models;
using Dapper;

namespace Keepr.Repositories
{
  public class BugsRepository
  {
    private readonly IDbConnection _db;

    public BugsRepository(IDbConnection db)
    {
      _db = db;
    }

    internal IEnumerable<Bug> GetAllBugs()
    {
      throw new NotImplementedException();
    }

    internal object GetBugById(int id)
    {
      throw new NotImplementedException();
    }

    internal int CreateNewBug(Bug newBugData)
    {
      throw new NotImplementedException();
    }

    internal void EditBugById(Bug editedBug)
    {
      throw new NotImplementedException();
    }

    internal void DeleteBugById(int id)
    {
      throw new NotImplementedException();
    }
  }
}