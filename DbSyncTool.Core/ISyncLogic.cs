using DbSyncTool.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbSyncTool.Core
{
    public interface ISyncLogic
    {
        void SyncEmployees();
        void SyncAccounts();
        void SyncSites();
        void SyncEvents();
        void SyncPortalLogins();
        void SyncWos();
        void SyncInspectionPointCategory();
        void SyncEventsSold();
        int GetSyncStatus();
        void InitDb();
        void SyncInspectionPointTypes();
        void SyncInspectionPoints();
        void SyncMaterialsSetup();
        void SyncMaterials();
        void SyncEventsPattern();
    }
}
