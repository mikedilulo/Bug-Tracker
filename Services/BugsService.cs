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

    internal object GetAllBugs()
    {
      throw new NotImplementedException();
    }

    internal object GetBugById(int id)
    {
      throw new NotImplementedException();
    }

    internal object CreateNewBug(Bug newBugData)
    {
      throw new NotImplementedException();
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