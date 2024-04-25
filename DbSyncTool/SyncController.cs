using DbSyncTool.Core;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DbSyncTool
{
    [ApiController]
    public class SyncController : ControllerBase
    {
        private readonly ISyncLogic _syncLogic;

        // using interfaces in Dependency Injection
        public SyncController(ISyncLogic syncLogic)
        {
            _syncLogic = syncLogic;
        }

        // GET: api/<SyncController>
        [HttpGet]
        [Route("api/[controller]/SyncEmployees")]
        public string SyncEmployees()
        {
            _syncLogic.SyncEmployees();
            return "Users - Employees synced";
        }

        [HttpGet]
        [Route("api/[controller]/SyncAccounts")]
        public string SyncAccounts()
        {
            _syncLogic.SyncAccounts();
            return "Relations synced";
        }

        [HttpGet]
        [Route("api/[controller]/SyncSites")]
        public string SyncSites()
        {
            _syncLogic.SyncSites();
            return "Surveys synced";
        }

        [HttpGet]
        [Route("api/[controller]/SyncEvents")]
        public string SyncEvents()
        {
            _syncLogic.SyncEvents();
            return "Visit Types synced";
        }

        [HttpGet]
        [Route("api/[controller]/SyncPortalLogins")]
        public string SyncPortalLogins()
        {
            _syncLogic.SyncPortalLogins();
            return "Users - Customers synced";
        }

        [HttpGet]
        [Route("api/[controller]/syncEventsSold")]
        public string syncEventsSold()
        {
            _syncLogic.SyncEventsSold();
            return "Services synced";
        }

        [HttpGet]
        [Route("api/[controller]/syncEventsPattern")]
        public string syncEventsPattern()
        {
            _syncLogic.SyncEventsPattern();
            return "Recurrences synced";
        }

        [HttpGet]
        [Route("api/[controller]/SyncInspectionPointCategory")]
        public string SyncInspectionPointCategory()
        {
            _syncLogic.SyncInspectionPointCategory();
            return "Inspection Point Categories synced";
        }

        [HttpGet]
        [Route("api/[controller]/SyncWos")]
        public string SyncWos()
        {
            _syncLogic.SyncWos();
            return "Ordersheet synced";
        }

        [HttpGet]
        [Route("api/[controller]/SyncInspectionPointTypes")]
        public string SyncInspectionPointTypes()
        {
            _syncLogic.SyncInspectionPointTypes();
            return "Bait station types synced";
        }

        [HttpGet]
        [Route("api/[controller]/SyncInspectionPoints")]
        public string SyncInspectionPoints()
        {
            _syncLogic.SyncInspectionPoints();
            return "Bait stations synced";
        }

        [HttpGet]
        [Route("api/[controller]/SyncMaterialsSetup")]
        public string SyncMaterialsSetup()
        {
            _syncLogic.SyncMaterialsSetup();
            return "Materials setup synced";
        }

        [HttpGet]
        [Route("api/[controller]/SyncMaterials")]
        public string SyncMaterials()
        {
            _syncLogic.SyncMaterials();
            return "Materials synced";
        }

        [HttpGet]
        [Route("api/[controller]/GetSyncStatus")]
        public int GetSyncStatus()
        {
            return _syncLogic.GetSyncStatus();
        }

        [HttpGet]
        [Route("api/[controller]/InitDb")]
        public string InitDb()
        {
            _syncLogic.InitDb();
            return "Database prepared";
        }
    }
}
