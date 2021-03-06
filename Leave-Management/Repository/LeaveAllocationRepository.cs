﻿using Leave_Management.Contracts;
using Leave_Management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management.Repository
{
    public class LeaveAllocationRepository : ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _db;
        public LeaveAllocationRepository(ApplicationDbContext db)              //dependency injection
        {
            this._db = db;
        }
        public bool Create(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Add(entity);
            return Save();
        }

        public bool Delete(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Remove(entity);
            return Save();
        }

        public ICollection<LeaveAllocation> FindAll()
        {
            return _db.LeaveAllocations.ToList();
        }

        public LeaveAllocation FindById(int Id)
        {
            var leaveAllocation = _db.LeaveAllocations.Find(Id);
            return leaveAllocation;

        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;

        }

        public bool Update(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Update(entity);
            return Save();
        }
    }
}
