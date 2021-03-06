﻿// CredentialItemReader.cs
//
// Copyright (C) 2013 Fabrício Godoy
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileInterchanger.Legacy.v0_1.Configuration
{
    class CredentialItemReader : ConfigReaderBase
    {
        public CredentialItemReader(SklLib.IO.ConfigFileReader reader, string section)
        {
            this.cfgreader = reader;
            this.sections = new string[] { section };
        }

        public string Domain { get { return GetString(sections[0], "Domain"); } }
        public string UserName { get { return GetString(sections[0], "UserName"); } }
        public string Password { get { return GetString(sections[0], "Password"); } }
    }
}
