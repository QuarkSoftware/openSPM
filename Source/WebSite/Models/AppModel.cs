﻿//******************************************************************************************************
//  AppModel.cs - Gbtc
//
//  Copyright © 2016, Grid Protection Alliance.  All Rights Reserved.
//
//  Licensed to the Grid Protection Alliance (GPA) under one or more contributor license agreements. See
//  the NOTICE file distributed with this work for additional information regarding copyright ownership.
//  The GPA licenses this file to you under the MIT License (MIT), the "License"; you may not use this
//  file except in compliance with the License. You may obtain a copy of the License at:
//
//      http://opensource.org/licenses/MIT
//
//  Unless agreed to in writing, the subject software distributed under the License is distributed on an
//  "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
//  License for the specific language governing permissions and limitations.
//
//  Code Modification History:
//  ----------------------------------------------------------------------------------------------------
//  02/17/2016 - J. Ritchie Carroll
//       Generated original version of source code.
//
//******************************************************************************************************

namespace openSPM.Models
{
    // Custom view models should inherit from or at least contain the same properties as AppModel as
    // these properties are used by _Layout.cshtml.
    public class AppModel
    {
        public AppModel()
        {
            if (MvcApplication.DefaultModel != null)
                this.CopyProperties(MvcApplication.DefaultModel);
        }

        public string CompanyName
        {
            get;
            set;
        }

        public string CompanyAcronym
        {
            get;
            set;
        }

        public string ApplicationName
        {
            get;
            set;
        }

        public string ApplicationDescription
        {
            get;
            set;
        }

        public string ApplicationKeywords
        {
            get;
            set;
        }

        public string DateTimeFormat
        {
            get;
            set;
        }

        public string BootstrapTheme
        {
            get;
            set;
        }
    }
}
