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
      string sql = "SELECT * FROM bugs";
      return _db.Query<Bug>(sql);
    }

    internal Bug GetBugById(int id)
    {
      string sql = @"
      SELECT * FROM bugs
      WHERE id = @id";
      return _db.QueryFirstOrDefault<Bug>(sql, new { id });
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