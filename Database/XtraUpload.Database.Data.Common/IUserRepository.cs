﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using XtraUpload.Domain;
using XtraUpload.Administration.Service.Common;
using XtraUpload.Authentication.Service.Common;
using XtraUpload.Setting.Service.Common;

namespace XtraUpload.Database.Data.Common
{
    public interface IUserRepository : IRepository<User>
    {
        /// <summary>
        /// Gets the user confirmation key
        /// </summary>
        Task<ConfirmationKeyResult> GetConfirmationKeyInfo(string confirmationId);

        /// <summary>
        /// Get the user role claims
        /// </summary>
        Task<RoleClaimsResult> GetUserRoleClaims(User user);

        /// <summary>
        /// Get all role claims pair
        /// </summary>
        Task<IEnumerable<RoleClaimsResult>> GetUsersRoleClaims();

        /// <summary>
        /// Group users count by date range
        /// </summary>
        Task<IEnumerable<ItemCountResult>> UsersCountByDateRange(DateTime start, DateTime end);
        /// <summary>
        /// Search users by name
        /// </summary>
        Task<IEnumerable<User>> SearchUsersByName(string name);

        /// <summary>
        /// Search of paging users
        /// </summary>
        Task<IEnumerable<UserExtended>> GetUsers(PageSearchModel model, Expression<Func<User, bool>> searchCriteria);
    }
}
