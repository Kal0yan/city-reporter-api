﻿using DataBase;
using DataBase.DbModels;

namespace DataAccessLayer.DbProv
{
    public class UserContext : IDb<UserDbModel, int>
    {
        private readonly AppDbContext _appDbContext;

        public UserContext(AppDbContext context)
        {
            _appDbContext = context;
        }

        public async Task Create(UserDbModel entity)
        {
            try
            {
                await _appDbContext.UserDbModels.AddAsync(entity);
                await _appDbContext.SaveChangesAsync();
            }
            catch (Exception)
            {

            }
        }

        public Task<UserDbModel> Read(int entity, bool useNavigationalProperties = false, bool isReadOnlyTrue = true)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserDbModel>> ReadAll(bool useNavigationalProperties = false, bool isReadOnlyTrue = true)
        {
            throw new NotImplementedException();
        }

        public Task Update(UserDbModel entity, bool useNavigationalProperties)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int key)
        {
            throw new NotImplementedException();
        }
    }
}
