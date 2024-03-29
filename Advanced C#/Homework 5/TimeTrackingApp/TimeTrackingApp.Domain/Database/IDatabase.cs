﻿using TimeTrackingApp.Domain.Models;

namespace TimeTrackingApp.Domain.Database
{
    public interface IDatabase<T> where T : User
    {
        void InsertUser(T user);
        User RemoveUser(User removedUser);
        void UpdateUser(T user);
        User CheckUser(string username, string password);

        User ActivateAccount(User activeUser);
    }
}
