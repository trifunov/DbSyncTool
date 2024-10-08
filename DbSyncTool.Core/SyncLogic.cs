﻿using Dapper;
using DbSyncTool.Core.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbSyncTool.Core
{
    public class SyncLogic : ISyncLogic
    {
        private CustomerSettings _customerSettings;

        public SyncLogic(IOptions<CustomerSettings> customerSettings)
        {
            _customerSettings = customerSettings.Value;
        }

        public void SyncEmployees()
        {
            DataTable table = new DataTable();

            using (var connection = new SqlConnection(_customerSettings.SourceConnectionString))
            {
                var reader = connection.ExecuteReader("PestScanEmployeesGet", null, null, null, CommandType.StoredProcedure);
                table.Load(reader);
            }

            using (var connection = new SqlConnection(_customerSettings.TargetConnectionString))
            {
                connection.Execute("TspEmployeesInsert", new { employees = table.AsTableValuedParameter("TspEmployees"), customerName = _customerSettings.CustomerName }, commandType: CommandType.StoredProcedure);
            }
        }

        public void SyncAccounts()
        {
            DataTable table = new DataTable();

            using (var connection = new SqlConnection(_customerSettings.SourceConnectionString))
            {
                var reader = connection.ExecuteReader("PestScanAccountsGet", null, null, null, CommandType.StoredProcedure);
                table.Load(reader);
            }

            using (var connection = new SqlConnection(_customerSettings.TargetConnectionString))
            {
                connection.Execute("TspAccountsInsert", new { accounts = table.AsTableValuedParameter("TspAccounts"), customerName = _customerSettings.CustomerName }, commandType: CommandType.StoredProcedure);
            }          
        }

        public void SyncSites()
        {
            DataTable table = new DataTable();

            using (var connection = new SqlConnection(_customerSettings.SourceConnectionString))
            {
                var reader = connection.ExecuteReader("PestScanSitesGet", null, null, null, CommandType.StoredProcedure);
                table.Load(reader);
            }

            using (var connection = new SqlConnection(_customerSettings.TargetConnectionString))
            {
                connection.Execute("TspSitesInsert", new { sites = table.AsTableValuedParameter("TspSites"), customerName = _customerSettings.CustomerName }, commandType: CommandType.StoredProcedure);
            }
        }


        public void SyncEvents()
        {
            DataTable table = new DataTable();

            using (var connection = new SqlConnection(_customerSettings.SourceConnectionString))
            {
                var reader = connection.ExecuteReader("PestScanEventsGet", null, null, null, CommandType.StoredProcedure);
                table.Load(reader);
            }

            using (var connection = new SqlConnection(_customerSettings.TargetConnectionString))
            {
                connection.Execute("TspEventsInsert", new { events = table.AsTableValuedParameter("TspEvents"), customerName = _customerSettings.CustomerName }, commandType: CommandType.StoredProcedure);
            }
        }

        public void SyncPortalLogins()
        {
            DataTable table = new DataTable();

            using (var connection = new SqlConnection(_customerSettings.SourceConnectionString))
            {
                var reader = connection.ExecuteReader("PestScanPortalLoginsGet", null, null, null, CommandType.StoredProcedure);
                table.Load(reader);
            }

            using (var connection = new SqlConnection(_customerSettings.TargetConnectionString))
            {
                connection.Execute("TspPortalLoginsInsert", new { portallogins = table.AsTableValuedParameter("TspPortalLogins") }, commandType: CommandType.StoredProcedure);
            }
        }

        public void SyncWos()
        {
            DataTable table = new DataTable();

            using (var connection = new SqlConnection(_customerSettings.SourceConnectionString))
            {
                var reader = connection.ExecuteReader("PestScanTspWosGet", null, null, null, CommandType.StoredProcedure);
                table.Load(reader);
            }

            using (var connection = new SqlConnection(_customerSettings.TargetConnectionString))
            {
                connection.Execute("TspWosInsert", new { wos = table.AsTableValuedParameter("TspWos"), customerName = _customerSettings.CustomerName }, commandType: CommandType.StoredProcedure);
            }
        }

        public void SyncInspectionPointCategory()
        {
            DataTable table = new DataTable();

            using (var connection = new SqlConnection(_customerSettings.SourceConnectionString))
            {
                var reader = connection.ExecuteReader("PestScanTspInspectionPointCategoryGet", null, null, null, CommandType.StoredProcedure);
                table.Load(reader);
            }

            using (var connection = new SqlConnection(_customerSettings.TargetConnectionString))
            {
                connection.Execute("TspInspectionPointCategoryInsert", new { ipcategory = table.AsTableValuedParameter("TspInspectionPointCategory"), customerName = _customerSettings.CustomerName }, commandType: CommandType.StoredProcedure);
            }
        }

        public void SyncEventsSold()
        {
            DataTable table = new DataTable();

            using (var connection = new SqlConnection(_customerSettings.SourceConnectionString))
            {
                var reader = connection.ExecuteReader("PestScanEventsSoldGet", null, null, null, CommandType.StoredProcedure);
                table.Load(reader);
            }

            using (var connection = new SqlConnection(_customerSettings.TargetConnectionString))
            {
                connection.Execute("TspEventsSoldInsert", new { eventssold = table.AsTableValuedParameter("TspEventsSold"), customerName = _customerSettings.CustomerName }, commandType: CommandType.StoredProcedure);
            }
        }

        public void SyncInspectionPointTypes()
        {
            DataTable table = new DataTable();

            using (var connection = new SqlConnection(_customerSettings.SourceConnectionString))
            {
                var reader = connection.ExecuteReader("PestScanTspInspectionPointTypeGet", null, null, null, CommandType.StoredProcedure);
                table.Load(reader);
            }

            using (var connection = new SqlConnection(_customerSettings.TargetConnectionString))
            {
                connection.Execute("TspInspectionPointTypeInsert", new { iptype = table.AsTableValuedParameter("TspInspectionPointType"), customerName = _customerSettings.CustomerName }, commandType: CommandType.StoredProcedure);
            }
        }

        public void SyncInspectionPoints()
        {
            DataTable table = new DataTable();

            using (var connection = new SqlConnection(_customerSettings.SourceConnectionString))
            {
                var reader = connection.ExecuteReader("PestScanTspInspectionPointsGet", null, null, null, CommandType.StoredProcedure);
                table.Load(reader);
            }

            using (var connection = new SqlConnection(_customerSettings.TargetConnectionString))
            {
                connection.Execute("TspInspectionPointsInsert", new { ips = table.AsTableValuedParameter("TspInspectionPoints"), customerName = _customerSettings.CustomerName }, commandType: CommandType.StoredProcedure);
            }
        }

        public void SyncMaterialsSetup()
        {
            DataTable table = new DataTable();

            using (var connection = new SqlConnection(_customerSettings.SourceConnectionString))
            {
                var reader = connection.ExecuteReader("PestScanMaterialsSetupGet", null, null, null, CommandType.StoredProcedure);
                table.Load(reader);
            }

            using (var connection = new SqlConnection(_customerSettings.TargetConnectionString))
            {
                connection.Execute("TspMaterialsSetupInsert", new { materialsSetup = table.AsTableValuedParameter("TspMaterialsSetup"), customerName = _customerSettings.CustomerName }, commandType: CommandType.StoredProcedure);
            }
        }

        public void SyncMaterials()
        {
            DataTable table = new DataTable();

            using (var connection = new SqlConnection(_customerSettings.SourceConnectionString))
            {
                var reader = connection.ExecuteReader("PestScanMaterialsGet", null, null, null, CommandType.StoredProcedure);
                table.Load(reader);
            }

            using (var connection = new SqlConnection(_customerSettings.TargetConnectionString))
            {
                connection.Execute("TspMaterialsInsert", new { materials = table.AsTableValuedParameter("TspMaterials"), customerName = _customerSettings.CustomerName }, commandType: CommandType.StoredProcedure);
            }
        }

        public void SyncEventsPattern()
        {
            DataTable table = new DataTable();

            using (var connection = new SqlConnection(_customerSettings.SourceConnectionString))
            {
                var reader = connection.ExecuteReader("PestScanEventsPatternGet", null, null, null, CommandType.StoredProcedure);
                table.Load(reader);
            }

            using (var connection = new SqlConnection(_customerSettings.TargetConnectionString))
            {
                connection.Execute("TspEventsPatternInsert", new { eventspattern = table.AsTableValuedParameter("TspEventsPattern"), customerName = _customerSettings.CustomerName }, commandType: CommandType.StoredProcedure);
            }
        }

        public void SyncTargetPest()
        {
            DataTable table = new DataTable();

            using (var connection = new SqlConnection(_customerSettings.SourceConnectionString))
            {
                var reader = connection.ExecuteReader("PestScanTargetPestGet", null, null, null, CommandType.StoredProcedure);
                table.Load(reader);
            }

            using (var connection = new SqlConnection(_customerSettings.TargetConnectionString))
            {
                connection.Execute("TspTargetPestInsert", new { targetpest = table.AsTableValuedParameter("TspTargetPest"), customerName = _customerSettings.CustomerName }, commandType: CommandType.StoredProcedure);
            }
        }

        public void SyncInspectionPointHistory()
        {
            DataTable table = new DataTable();

            using (var connection = new SqlConnection(_customerSettings.SourceConnectionString))
            {
                var reader = connection.ExecuteReader("PestScanInspectionPointHistoryGet", null, null, null, CommandType.StoredProcedure);
                table.Load(reader);
            }

            using (var connection = new SqlConnection(_customerSettings.TargetConnectionString))
            {
                connection.Execute("TspInspectionPointHistoryInsert", new { inspectionpointhistory = table.AsTableValuedParameter("TspInspectionPointHistory"), customerName = _customerSettings.CustomerName }, commandType: CommandType.StoredProcedure);
            }
        }

        public int GetSyncStatus()
        {
            using (var connection = new SqlConnection(_customerSettings.TargetConnectionString))
            {
                return connection.ExecuteScalar<int>("AppCustomerSyncStatusesGetByName", new { customerName = _customerSettings.CustomerName }, commandType: CommandType.StoredProcedure);
            }
        }

        public void InitDb()
        {
            using (var connection = new SqlConnection(_customerSettings.TargetConnectionString))
            {
                connection.Execute("DbInitialSetupBeforeMigration", new { customerName = _customerSettings.CustomerName, customerShortName = _customerSettings.CustomerShortName }, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
