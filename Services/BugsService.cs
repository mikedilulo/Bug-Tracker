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
  }
}