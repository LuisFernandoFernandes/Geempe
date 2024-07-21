﻿using Geempe.Domain.Entities;
using Geempe.Infra.Context;
using Geempe.Infra.Interfaces;

namespace Geempe.Infra.Repository;

public class UserRepository(AppDBContext context) : RepositoryBase<User>(context), IUserRepository
{

}
