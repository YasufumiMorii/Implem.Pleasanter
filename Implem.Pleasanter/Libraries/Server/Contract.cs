﻿using Implem.Libraries.Utilities;
using Implem.Pleasanter.Libraries.DataSources;
using Implem.Pleasanter.Libraries.Settings;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
namespace Implem.Pleasanter.Libraries.Server
{
    public static class Contract
    {
        public static Dictionary<int, ContractSettings> ContractHash =
            new Dictionary<int, ContractSettings>();

        public static void Set()
        {
            var tenantId = Sessions.TenantId();
            var cs = ContractSettings(tenantId);
            if (!ContractHash.ContainsKey(tenantId))
            {
                ContractHash.Add(tenantId, cs);
            }
            else
            {
                ContractHash[tenantId] = cs;
            }
        }

        private static ContractSettings ContractSettings(int tenantId)
        {
            var dataRow = Rds.ExecuteTable(statements:
                Rds.SelectTenants(
                    column: Rds.TenantsColumn()
                        .ContractSettings()
                        .ContractDeadline(),
                    where: Rds.TenantsWhere().TenantId(tenantId)))
                        .AsEnumerable()
                        .FirstOrDefault();
            var cs = dataRow?["ContractSettings"]?.ToString().Deserialize<ContractSettings>();
            if (cs != null)
            {
                cs.Deadline = dataRow["ContractDeadline"].ToDateTime();
            }
            return cs;
        }

        public static string DisplayName()
        {
            var tenantId = Sessions.TenantId();
            return
                ContractHash.ContainsKey(tenantId)
                    ? ContractHash[tenantId]?.DisplayName
                    : null;
        }

        public static bool OverDeadline()
        {
            var tenantId = Sessions.TenantId();
            return
                ContractHash.ContainsKey(tenantId) &&
                ContractHash[tenantId]?.Deadline.InRange() == true &&
                ContractHash[tenantId]?.Deadline.ToDateTime() < DateTime.Now.ToLocal();
        }

        public static bool UsersLimit(int number = 1)
        {
            var tenantId = Sessions.TenantId();
            return
                ContractHash.ContainsKey(tenantId) &&
                ContractHash[tenantId]?.Users > 0 &&
                Rds.ExecuteScalar_int(statements: Rds.SelectUsers(
                    column: Rds.UsersColumn().UsersCount(),
                    where: Rds.UsersWhere().TenantId(tenantId))) + number >
                        ContractHash[tenantId]?.Users;
        }

        public static bool SitesLimit(int number = 1)
        {
            var tenantId = Sessions.TenantId();
            return
                ContractHash.ContainsKey(tenantId) &&
                ContractHash[tenantId]?.Sites > 0 &&
                Rds.ExecuteScalar_int(statements: Rds.SelectSites(
                    column: Rds.SitesColumn().SitesCount(),
                    where: Rds.SitesWhere().TenantId(tenantId))) + number >
                        ContractHash[tenantId]?.Sites;
        }

        public static bool ItemsLimit(long siteId, int number = 1)
        {
            var tenantId = Sessions.TenantId();
            return
                ContractHash.ContainsKey(tenantId) &&
                ContractHash[tenantId]?.Sites > 0 &&
                Rds.ExecuteScalar_int(statements: Rds.SelectItems(
                    column: Rds.ItemsColumn().ItemsCount(),
                    where: Rds.ItemsWhere().SiteId(siteId))) + number >
                        ContractHash[tenantId]?.Items;
        }

        public static bool Import()
        {
            var tenantId = Sessions.TenantId();
            return
                ContractHash.ContainsKey(tenantId) &&
                ContractHash[tenantId]?.Import != false;
        }

        public static bool Export()
        {
            var tenantId = Sessions.TenantId();
            return
                ContractHash.ContainsKey(tenantId) &&
                ContractHash[tenantId]?.Export != false;
        }

        public static bool Notice()
        {
            var tenantId = Sessions.TenantId();
            return
                ContractHash.ContainsKey(tenantId) &&
                ContractHash[tenantId]?.Notice != false;
        }

        public static bool Mail()
        {
            var tenantId = Sessions.TenantId();
            return
                ContractHash.ContainsKey(tenantId) &&
                ContractHash[tenantId]?.Mail != false;
        }

        public static bool Style()
        {
            var tenantId = Sessions.TenantId();
            return
                ContractHash.ContainsKey(tenantId) &&
                ContractHash[tenantId]?.Style != false;
        }

        public static bool Script()
        {
            var tenantId = Sessions.TenantId();
            return
                ContractHash.ContainsKey(tenantId) &&
                ContractHash[tenantId]?.Script != false;
        }
    }
}