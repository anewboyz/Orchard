using System.Collections.Generic;
using Orchard.ImportExport.Models;

namespace Orchard.ImportExport.ViewModels {
    public class DataExportStepViewModel {
        public DataExportStepViewModel() {
            ContentTypes = new List<ContentTypeEntry>();
        }

        public IList<ContentTypeEntry> ContentTypes { get; set; }
        public VersionHistoryOptions VersionHistoryOptions { get; set; }
        public int? ImportBatchSize { get; set; }
    }
}