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
    internal IEnumerable<Bug> GetAllClosedBugs()
    {
      string sql = "SELECT * FROM bugs WHERE isClosed = 1";
      return _db.Query<Bug>(sql);
    }

    internal Bug GetBugById(int id)
    {
      string sql = "SELECT * FROM bugs WHERE id = @id";
      return _db.QueryFirstOrDefault<Bug>(sql, new { id });
    }


    internal int CreateNewBug(Bug newBugData)
    {
      string sql = @"
      INSERT INTO bugs
      (userId, title, subject, description, reportedBy, isClosed, daysOpen, lastModified, bugCreated, bugClosed)
      VALUES
      (@UserId, @Title, @Subject, @Description, @ReportedBy, @IsClosed, @DaysOpen, @LastModified, @BugCreated, @BugClosed);
      SELECT LAST_INSERT_ID();
      ";
      int id = _db.ExecuteScalar<int>(sql, newBugData);
      newBugData.Id = id;
      return id;
    }

    internal void EditBugById(Bug editedBug)
    {
      string sql = @"
      UPDATE bugs
      SET
      userId = @UserId,
      title = @Title,
      subject = @Subject,
      description = @Description,
      reportedBy = @ReportedBy,
      isClosed = @IsClosed,
      daysOpen = @DaysOpen,
      lastModified = @LastModified,
      bugCreated = @BugCreated,
      bugClosed = @BugClosed
      WHERE(id = @id)";
      _db.Execute(sql, editedBug);
    }

    //SOFT DELETE WILL BE IMPLEMENTED IN PROJECT. THIS IS JUST POSTMAN PURPOSES. EDIT WILL BE THE SOFT DELETE
    internal void DeleteBugById(int id)
    {
      string sql = "DELETE FROM bugs WHERE id = @id";
      _db.Execute(sql, new { id });
    }
  }
}