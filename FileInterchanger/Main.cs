﻿// Main.cs
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
using System.ServiceProcess;

namespace FileInterchanger
{
    class MainClass
    {
        public const string PROGRAM_NAME = "FileInterchanger";
        // Latest release: 0.1.0.47
        // Major.Minor.Maintenance.Build
        public const string PROGRAM_VERSION = "0.2.0.49";
        public const string PROGRAM_TITLE = PROGRAM_NAME + " 0.2";

        public static readonly bool DEBUG = System.Diagnostics.Debugger.IsAttached;

        public static void Main(string[] args)
        {
            if (Logger.Default == null)
                throw new Exception("Couldn't create EventLog");

            Service ftp = new Service();

            if (!DEBUG)
            {
                ServiceBase[] servicesToRun = new ServiceBase[] { ftp };
                System.ServiceProcess.ServiceBase.Run(servicesToRun);
            }
            else
            {
                ftp.StartDebug(args);
            }
        }
    }
}
