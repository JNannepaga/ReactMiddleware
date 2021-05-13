using Mapster;
using System;
using Model = SchoolManagement.Data.Models;
using Entity = SchoolManagement.Repository.Entities;

namespace SchoolManagement.Services
{
    public static class TypeMapperConfig
    {
        public static void Register()
        {
            TypeAdapterConfig<Entity.Student, Model.Student>.NewConfig()
                .Map(d => d.RollId, s => s.RollId)
                .Map(d => d.FirstName, s => s.FirstName)
                .Map(d => d.LastName, s => s.LastName)
                .Map(d => d.Standard, s => (Entity.Standard)s.Standard);

            TypeAdapterConfig<Entity.Teacher, Model.Teacher>.NewConfig()
                .Map(d => d.TeacherId, s => s.TeacherId)
                .Map(d => d.FirstName, s => s.FirstName)
                .Map(d => d.LastName, s => s.LastName)
                .Map(d => d.Subject, s => (Entity.Subject)s.Subject);

            TypeAdapterConfig<Entity.UserManagement, Model.CurrentUser>.NewConfig()
                .Map(d => d.RegNum, s => s.RegNum)
                .Map(d => d.UserName, s => s.UserName)
                .Map(d => d.Role, s => (Entity.UserRoles)s.Role);
        }
    }
}
