using System.Data.Entity;
using System.Linq;
using FluentMigrator;
using Samba.Domain.Models.Automation;
using Samba.Localization.Properties;
using Samba.Presentation.Services.Common;

namespace Samba.Persistance.DBMigration
{
    [Migration(14,TransactionBehavior.None)]
    public class Migration_014 : Migration
    {
        public override void Up()
        {
            var dc = ApplicationContext as DbContext;
            Create.Column("DisplayUnderTicket").OnTable("AutomationCommandMaps").AsBoolean().WithDefaultValue(false);
        }

        public override void Down()
        {

        }
    }
}