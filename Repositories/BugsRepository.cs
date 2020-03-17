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
  }
}