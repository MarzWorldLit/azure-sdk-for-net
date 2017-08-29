// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.StreamAnalytics;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes an Azure SQL database output data source.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Microsoft.Sql/Server/Database")]
    [Rest.Serialization.JsonTransformation]
    public partial class AzureSqlDatabaseOutputDataSource : OutputDataSource
    {
        /// <summary>
        /// Initializes a new instance of the AzureSqlDatabaseOutputDataSource
        /// class.
        /// </summary>
        public AzureSqlDatabaseOutputDataSource()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureSqlDatabaseOutputDataSource
        /// class.
        /// </summary>
        /// <param name="server">The name of the SQL server containing the
        /// Azure SQL database. Required on PUT (CreateOrReplace)
        /// requests.</param>
        /// <param name="database">The name of the Azure SQL database. Required
        /// on PUT (CreateOrReplace) requests.</param>
        /// <param name="user">The user name that will be used to connect to
        /// the Azure SQL database. Required on PUT (CreateOrReplace)
        /// requests.</param>
        /// <param name="password">The password that will be used to connect to
        /// the Azure SQL database. Required on PUT (CreateOrReplace)
        /// requests.</param>
        /// <param name="table">The name of the table in the Azure SQL
        /// database. Required on PUT (CreateOrReplace) requests.</param>
        public AzureSqlDatabaseOutputDataSource(string server = default(string), string database = default(string), string user = default(string), string password = default(string), string table = default(string))
        {
            Server = server;
            Database = database;
            User = user;
            Password = password;
            Table = table;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the SQL server containing the Azure SQL
        /// database. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "properties.server")]
        public string Server { get; set; }

        /// <summary>
        /// Gets or sets the name of the Azure SQL database. Required on PUT
        /// (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "properties.database")]
        public string Database { get; set; }

        /// <summary>
        /// Gets or sets the user name that will be used to connect to the
        /// Azure SQL database. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "properties.user")]
        public string User { get; set; }

        /// <summary>
        /// Gets or sets the password that will be used to connect to the Azure
        /// SQL database. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "properties.password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the name of the table in the Azure SQL database.
        /// Required on PUT (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "properties.table")]
        public string Table { get; set; }

    }
}