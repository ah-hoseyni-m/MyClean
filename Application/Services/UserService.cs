using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Dto;
using Domain.Entities;
using Domain.Repository;

namespace Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _IUserRepository;
    public UserService(IUserRepository userRepository)
    {
        _IUserRepository = userRepository;
    }
    public async Task<UserModel> Create(UserModel model)
    {
        var entity = new User()
        {
            UserName = model.UserName,
            Email = model.Email,
            CreateAt = DateTime.Now,
            Gender = model.Gender,
            Family = model.Family,
            Name = model.Name,
            PasswordHash = model.PasswordHash
        };

        await _IUserRepository.Create(entity);
        //model.id = entity.Id;

        return model;

    }

    public async Task<UserModel> Update(UserModel model)
    {
        var entity = new User()
        {
            UserName = model.UserName,
            Email = model.Email,
            CreateAt = DateTime.Now,
            Gender = model.Gender,
            Family = model.Family,
            Name = model.Name,
            PasswordHash = model.PasswordHash
        };

        await _IUserRepository.Edit(entity);
        //model.id = entity.Id;

        return model;
    }
}
