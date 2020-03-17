using System;
using System.Collections.Generic;
using System.Data;
using Keepr.Models;
using Keepr.Repositories;

namespace Keepr.Services
{
  public class BugsService
  {
    private readonly BugsRepository _bugrepo;
    public BugsService(BugsRepository bugrepo)
    {
      _bugrepo = bugrepo;
    }

    internal IEnumerable<Bug> GetAllBugs()
    {
      return _bugrepo.GetAllBugs();
    }

    internal Bug GetBugById(int id)
    {
      var foundBug = _bugrepo.GetBugById(id);
      if (foundBug == null) { throw new Exception("Invalid: Bug Cannot Be Found"); }
      return foundBug;
    }

    internal Bug CreateNewBug(Bug newBugData)
    {
      newBugData.Id = _bugrepo.CreateNewBug(newBugData);
      return newBugData;
    }

    internal object EditBugById(Bug editedBug)
    {
      throw new NotImplementedException();
    }

    internal object DeleteBugById(int id)
    {
      throw new NotImplementedException();
    }
  }
}