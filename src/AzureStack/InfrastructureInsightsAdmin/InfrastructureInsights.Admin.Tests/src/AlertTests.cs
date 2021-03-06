﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//

using Microsoft.AzureStack.Management.InfrastructureInsights.Admin;
using Microsoft.AzureStack.Management.InfrastructureInsights.Admin.Models;
using Xunit;

namespace InfrastructureInsights.Tests
{

    public class AlertTests : InfrastructureInsightsTestBase
    {

        private void AssertAlertsAreSame(Alert expected, Alert found) {
            if (expected == null)
            {
                Assert.Null(found);
            }
            else
            {
                Assert.True(InfrastructureInsightsCommon.ResourceAreSame(expected, found));
                Assert.Equal(expected.AlertId, found.AlertId);

                if (expected.AlertProperties == null)
                {
                    Assert.Null(found.AlertProperties);
                }
                else
                {
                    Assert.Equal(expected.AlertProperties.Count, found.AlertProperties.Count);
                }

                Assert.Equal(expected.ClosedByUserAlias, found.ClosedByUserAlias);
                Assert.Equal(expected.ClosedTimestamp, found.ClosedTimestamp);
                Assert.Equal(expected.CreatedTimestamp, found.CreatedTimestamp);

                if (expected.Description == null)
                {
                    Assert.Null(found.Description);
                }
                else
                {
                    Assert.Equal(expected.Description.Count, found.Description.Count);
                }

                Assert.Equal(expected.FaultId, found.FaultId);
                Assert.Equal(expected.FaultTypeId, found.FaultTypeId);
                Assert.Equal(expected.ImpactedResourceDisplayName, found.ImpactedResourceDisplayName);
                Assert.Equal(expected.ImpactedResourceId, found.ImpactedResourceId);
                Assert.Equal(expected.LastUpdatedTimestamp, found.LastUpdatedTimestamp);

                if (expected.Remediation == null)
                {
                    Assert.Null(found.Remediation);
                }
                else
                {
                    Assert.Equal(expected.Remediation.Count, found.Remediation.Count);
                }

                Assert.Equal(expected.ResourceProviderRegistrationId, found.ResourceProviderRegistrationId);
                Assert.Equal(expected.ResourceRegistrationId, found.ResourceRegistrationId);
                Assert.Equal(expected.Severity, found.Severity);
                Assert.Equal(expected.State, found.State);
                Assert.Equal(expected.Title, found.Title);
            }
        }

        private void ValidateAlert(Alert alert) {
            Assert.NotNull(alert);
            Assert.NotNull(alert.AlertId);
            Assert.NotNull(alert.AlertProperties);

            // Can be null
            // Assert.NotNull(alert.ClosedByUserAlias, "ClosedByUserAlias");

            // Might not be closed yet!
            //Assert.NotNull(alert.ClosedTimestamp, "ClosedTimestamp");
            Assert.NotNull(alert.CreatedTimestamp);
            Assert.NotNull(alert.Description);
            //Assert.NotNull(alert.FaultId, "FaultId");
            Assert.NotNull(alert.FaultTypeId);
            Assert.NotNull(alert.ImpactedResourceDisplayName);
            Assert.NotNull(alert.ImpactedResourceId);
            Assert.NotNull(alert.LastUpdatedTimestamp);
            Assert.NotNull(alert.Remediation);
            Assert.NotNull(alert.ResourceProviderRegistrationId);
            // TODO: Can be null.  Is there a way to know when not supposed to be null?
            // Assert.NotNull(alert.ResourceRegistrationId);
            Assert.NotNull(alert.Severity);
            Assert.NotNull(alert.State);
            Assert.NotNull(alert.Title);

        }

        // Create and validate client
        [Fact]
        public void TestListAlerts() {
            RunTest((client) => {
                var alerts = client.Alerts.List(Location);
                Common.MapOverIPage(alerts, client.Alerts.ListNext, ValidateAlert);
                Common.WriteIPagesToFile(alerts, client.Alerts.ListNext, "ListAllAlerts.txt", (alert) => alert.FaultId);
            });
        }

        [Fact]
        public void TestGetAlert() {
            RunTest((client) => {
                var alert = client.Alerts.List(Location).GetFirst();
                var retrieved = client.Alerts.Get(Location, alert.Name);
                AssertAlertsAreSame(alert, retrieved);
            });
        }

        [Fact]
        public void TestGetAllAlerts() {
            RunTest((client) => {
                var alerts = client.Alerts.List(Location);
                Common.MapOverIPage(alerts, client.Alerts.ListNext, (alert) => {
                    var retrieved = client.Alerts.Get(Location, alert.Name);
                    AssertAlertsAreSame(alert, retrieved);
                });
            });
        }



        [Fact]
        public void TestCloseAlert() {
            RunTest((client) => {
                bool done = false;
                var alerts = client.Alerts.List(Location);
                Common.MapOverIPage(alerts, client.Alerts.ListNext, (alert) => {
                    if (done) return;
                    if (alert.State != "Closed")
                    {
                        alert.State = "Closed";
                        client.Alerts.Close(Location, alert.Name, "AlertCloseTests", alert);
                        var retrieved = client.Alerts.Get(Location, alert.Name);
                        Assert.Equal("Closed", retrieved.State);

                        done = true;
                    }
                });
            });
        }
    }
}
