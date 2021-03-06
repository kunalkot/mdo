﻿#region CopyrightHeader
//
//  Copyright by Contributors
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//         http://www.apache.org/licenses/LICENSE-2.0.txt
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gov.va.medora.mdo.domain.sm.enums;

namespace gov.va.medora.mdo.domain.sm
{
    [Serializable]
    public class Patient : gov.va.medora.mdo.domain.sm.User
    {

        private DateTime _dob;

        public DateTime Dob
        {
            get { return _dob; }
            set { _dob = value; }
        }
        private string _icn;

        public string Icn
        {
            get { return _icn; }
            set { _icn = value; }
        }
        private List<PatientFacility> _facilities;

        public List<PatientFacility> Facilities
        {
            get { return _facilities; }
            set { _facilities = value; }
        }
        private DateTime _relationshipUpdate;

        public DateTime RelationshipUpdate
        {
            get { return _relationshipUpdate; }
            set { _relationshipUpdate = value; }
        }

        public Patient()
        {
            UserType = UserTypeEnum.PATIENT;
            ParticipantType = ParticipantTypeEnum.PATIENT;
        }
    }
}
