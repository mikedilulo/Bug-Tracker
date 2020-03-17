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

    internal IEnumerable<Bug> GetAllClosedBugs()
    {
      return _bugrepo.GetAllClosedBugs();
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

    internal Bug EditBugById(Bug editedBug)
    {
      Bug bugExists = _bugrepo.GetBugById(editedBug.Id);
      if (bugExists == null) { throw new Exception("Invalid: Cannot Edit Bug"); }
      _bugrepo.EditBugById(editedBug);
      return editedBug;
    }


    //ONLY FOR POSTMAN PURPOSES AND DELETING DATA. DELETE WILL BE "SOFT"

    internal object DeleteBugById(int id)
    {
      Bug bugExists = _bugrepo.GetBugById(id);
      if (bugExists == null) { throw new Exception("Invalid: Bug Cannot Be Deleted"); }
      _bugrepo.DeleteBugById(id);
      return "Successfully Deleted Bug";
    }
  }
}