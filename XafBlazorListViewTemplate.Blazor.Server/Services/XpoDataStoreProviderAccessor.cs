﻿using System;
using DevExpress.ExpressApp.Xpo;

namespace XafBlazorListViewTemplate.Blazor.Server.Services {
    public class XpoDataStoreProviderAccessor {
        public IXpoDataStoreProvider DataStoreProvider { get; set; }
    }
}