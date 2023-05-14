// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Hosts.Models
{
    /// <summary>
    /// Content of the hosts file
    /// </summary>
    public class HostsData
    {
        /// <summary>
        /// Gets the lines that aren't parsed
        /// </summary>
        public string Unparsed { get; private set; }

        /// <summary>
        /// Gets the parsed entries
        /// </summary>
        public ReadOnlyCollection<Entry> Entries { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the hosts file contains at least one entry that exceeds the maximum number of hosts
        /// </summary>
        public bool HostsExceedingMaxFound { get; private set; }

        public HostsData()
        {
            Unparsed = string.Empty;
            Entries = new ReadOnlyCollection<Entry>(new List<Entry>());
            HostsExceedingMaxFound = false;
        }

        public HostsData(string unparsed, List<Entry> entries, bool hostsExceedingMaxFound)
        {
            Unparsed = unparsed;
            Entries = entries.AsReadOnly();
            HostsExceedingMaxFound = hostsExceedingMaxFound;
        }
    }
}
